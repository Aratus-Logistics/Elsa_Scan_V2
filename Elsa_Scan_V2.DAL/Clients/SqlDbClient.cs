using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Elsa_Scan_V2.DAL.Interfaces;
using Elsa_Scan_V2.DAL.Models;
using System.Data;

namespace Elsa_Scan_V2.DAL.Clients
{
    public class SqlDbClient
    {
        //Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
       
        private static string _connectionString = "Server=tcp:aratus-test-db.database.windows.net,1433;Initial Catalog=Aratus_test;Persist Security Info=False;User ID=BrentBoden;Password=Ordina123;";
        private string newLine = Environment.NewLine;

        /// <summary>
        /// Creates a connection for the database
        /// </summary>
        /// <param name="open">
        ///     if true the connection is opened
        /// </param>
        /// <returns>
        ///     the made database connection.
        /// </returns>
        public static SqlConnection GetConnection(bool open)
        {
            SqlConnection _conn = new SqlConnection();
            _conn.ConnectionString = _connectionString;
            if (open)
            {
                _conn.Open();
            }
            return _conn;
        }

        /// <summary>
        /// Get the resoucedata for the given resource
        /// Resource can be "Location", "SKU" or "LPN"
        /// </summary>
        /// <param name="readQueryString">
        ///     Query for getting all the resource data.
        /// </param>
        /// <param name="resourceName">
        ///     Name of the queried resouce.
        /// </param>
        /// <returns>
        ///     SqlDbReponse --> StatusCode, message and subtitle
        /// </returns>
        public static SqlDbResponse GetResourceData(string readQueryString, ResourceModel resource)
        {
            try
            {
                SqlDbResponse _response = new SqlDbResponse();

                _response = ExecuteReadQuery(readQueryString);

                _response.SubTitle = _composeResourceMessage(resource);

                return _response;
            }
            catch (Exception ex)
            {
                return new SqlDbResponse() { Status = ResponseCode.Error, Message = "Error: " + ex.Message };
            }
        }

        /// <summary>
        /// Execute the real read query
        /// </summary>
        /// <param name="queryString">
        ///     Query to be executed
        /// </param>
        /// <returns>
        ///     SqlDbReponse --> StatusCode and message
        /// </returns>
        public static SqlDbResponse ExecuteReadQuery(string queryString)
        {
            try
            {
                 DataTable _data = new DataTable();

                using (SqlConnection _conn = SqlDbClient.GetConnection(true))
                {
                    using (SqlCommand _command = new SqlCommand(queryString, _conn))
                    {
                        _command.ExecuteNonQuery();
                        using (SqlDataAdapter _dataAdapter = new SqlDataAdapter(_command))
                        {
                            _dataAdapter.Fill(_data);
                        }
                    }
                }

                var _result = _processReadQueryData(_data);

                return _result;
            }
            catch (Exception ex)
            {                
                return new SqlDbResponse() { Status = ResponseCode.Error, Message = "Error: " + ex.Message};
            }
        }

        /// <summary>
        ///     Creates a SqlDbResponse from the read query data
        /// </summary>
        /// <param name="data">
        ///     the datatable from the read query
        /// </param>
        /// <returns>
        ///     the response of the read query
        /// </returns>
        private static SqlDbResponse _processReadQueryData(DataTable data)
        {
            SqlDbResponse _response = new SqlDbResponse();

            _response.Status = ResponseCode.Ok;
            _response.Message = _composeReadMessage(data);

            return _response;
        }

        /// <summary>
        ///     Creates the message from the read query
        /// </summary>
        /// <param name="data">
        ///     the datatable from the read query
        /// </param>
        /// <returns>
        ///     the read message from the query
        /// </returns>
        private static string _composeReadMessage(DataTable data)
        {
            string _message = string.Empty;
            if (data.Rows.Count > 1)
            {
                //Multiple results
                StringBuilder _sb = new StringBuilder();
                foreach (DataRow _row in data.Rows)
                {
                    _sb.AppendLine(_composeLine(_row));
                    _sb.AppendLine();
                }
                _message = _sb.ToString();
            }
            else
            {
                //Single result
                var _referenceData = data.Rows[0];

                _message = _composeLine(_referenceData);
            }
            return _message;
        }

        /// <summary>
        ///     creates a line of text from a datarow of the datatable
        /// </summary>
        /// <param name="row">
        ///     the row that need to be processed
        /// </param>
        /// <returns>
        ///     text representation of the datarow
        /// </returns>
        private static string _composeLine(DataRow row)
        {
            //TODO: Replace strings by real column names

            var _model = new LookupModel();

            _model.SKU = row[0].ToString(); // row["SKU"].ToString();
            _model.LPN = row[1].ToString(); // row["LPN"].ToString();

            _model.Quantity = 0;
            try
            {
                _model.Quantity = int.Parse(row["Qauntity"].ToString());
            }
            catch (Exception) 
             { 
               //quantity is not an integer so its zero
             }

            _model.Location = row[3].ToString(); // row["Location"].ToString();
            _model.Storer = row[4].ToString(); // row["Storer"].ToString();

            return string.Format("SKU:{0}\nLPN:{1}\nQTY:{2}\nLocation:{3}\nStorer:{4}",
                    _model.SKU,
                    _model.LPN,
                    _model.Quantity,
                    _model.Location,
                    _model.Storer);
        }

        /// <summary>
        ///     creates a text represendation of the requested resource.
        /// </summary>
        /// <param name="resource">
        ///     the requested resource
        /// </param>
        /// <returns>
        ///     a text representation of the requested resource.
        /// </returns>
        private static string _composeResourceMessage(ResourceModel resource)
        {
            return string.Format("{0}: {1}", resource.Name, resource.Value);
        }
    }
}
