using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Utilities
{
    public static class HelperMethods
    {
        /// <summary>
        /// Static operation to get the name of the method calling this method
        /// </summary>
        /// <param name="name"></param>
        /// <returns>The method calling name</returns>
        public static string GetCallerMemberName([CallerMemberName]string name = "")
        {
            return name;
        }

        /// <summary>
        /// Return a provide date formatted to a string for usage with SQL query parameters
        /// </summary>
        /// <param name="date">Date in question to format</param>
        /// <returns>A date string formatted to yyyy-MM-dd HH:mm:ss</returns>
        public static string GenerateSQLFormattedDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string ParseModelStateErrorsToString(ModelStateDictionary state)
        {
            return string.Join("; ", state.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
        }
    }


}