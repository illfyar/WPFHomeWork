using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class HandlingObjects
    {
        public static void CopyValueProperties<T>(T recipientObj, T sourceObj)
        {
            var properties = typeof(T).GetProperties().Where(x => x.GetValue(sourceObj) != null);
            foreach (PropertyInfo property in properties)
            {
                if (property.CanWrite)
                {
                    property.SetValue(recipientObj, property.GetValue(sourceObj));
                }
            }
        }
    }
}
