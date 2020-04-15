using System;

namespace ACME.Common
{

    /// <summary>
    /// clase mainupuladora de cadenas
    /// </summary>
    public static class StringHandler
    {
        /// <summary>
        /// Inserta espacios cada que la letra esta en mayuscula en un string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            var result = string.Empty;
            if(!string.IsNullOrEmpty(source))
            {
                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        //quita cualquier espacio de mas
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            //elimina el primer espacion en blanco
            return result.Trim();
        }
    }
}
