using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NiWFComponent.Logics
{ 
    public static class Logics
    {
        public static string GetValue(this object obj, string key)
        {
            return obj.GetPropertyValue(key).ToString();
        }
        public static  void SetValue(this object obj, string key, object value)
        {
            obj.SetPropertyValue(key, value);
        }
        public static string GetValue(this object obj, int key)
        {
            return obj.GetValue(obj.GetType().GetProperties().ToArray()[key].Name);
        }
        public static  void SetValue(this object obj, int key, object value)
        {
            var properties = obj.GetType().GetProperties().ToArray();
            var keystring = properties[key].Name;
            obj.SetValue(keystring, value);
        }
        public static string GetNameOfProperty(this object obj, int key)
        {
            return obj.GetType().GetProperties().ToArray()[key].Name;
        }
        public static int GetCountOfProperties(this object obj)
        {
            return obj.GetType().GetProperties().ToArray().Length;
        }
      



        public static object GetPropertyValue(this object car, string propertyName)
        {
            return car.GetType().GetProperties().Single((PropertyInfo pi) => pi.Name == propertyName)
                .GetValue(car, null);
        }

        public static void SetPropertyValue(this object car, string propertyName, object value)
        {
            car.GetType().GetProperties().Single((PropertyInfo pi) => pi.Name == propertyName)
                .SetValue(car, value);
        }
    }
}
