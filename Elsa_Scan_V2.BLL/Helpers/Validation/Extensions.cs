using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Elsa_Scan_V2.BLL.Helpers.Validation
{
    public class Extensions<T> where T : class
    {
        public static bool Validate()
        {
            T _class = Activator.CreateInstance<T>();
            FieldInfo[] fields = _class.GetType().GetFields().ToArray();
            foreach (FieldInfo field in fields)
            {
                var value = field.GetValue(_class);

                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    //all fields need to be filled in
                    return false;
                }
            }
            return true;
        }
    }
}
