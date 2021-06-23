using System;
using System.Linq;
using System.Reflection;
using MyOnionApi.Application.Interfaces;

namespace MyOnionApi.Application.Helpers
{
    public class ModelHelper : IModelHelper
    {
        /// <summary>
        /// Check field name in the model class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public string ValidateModelFields<T>(string fields)
        {
            string retString = string.Empty;

            var bindingFlags = BindingFlags.Instance |
                               BindingFlags.NonPublic |
                               BindingFlags.Public;
            var listFields = typeof(T).GetProperties(bindingFlags).Select(f => f.Name).ToList();
            string[] arrayFields = fields.Split(',');
            foreach (var field in arrayFields)
            {
                if (listFields.Contains(field.Trim(), StringComparer.OrdinalIgnoreCase))
                    retString += field + ",";
            }

            ;
            return retString;
        }

        /// <summary>
        /// Get list of field names in the model class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public string GetModelFields<T>()
        {
            string retString = string.Empty;

            var bindingFlags = BindingFlags.Instance |
                               BindingFlags.NonPublic |
                               BindingFlags.Public;
            var listFields = typeof(T).GetProperties(bindingFlags).Select(f => f.Name).ToList();

            foreach (string field in listFields)
            {
                retString += field + ",";
            }

            return retString;
        }
    }
}