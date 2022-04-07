using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicesCatalog.API.Utilities
{
    public class ListConverter : ValueConverter<IEnumerable<int>, string>
    {
        public ListConverter() : base(le => ListToString(le), (s => StringToList(s)))
        {

        }

        public static string ListToString(IEnumerable<int> value)
        {
            if (value == null || value.Count() == 0)
            {
                return null;
            }

            return string.Join(',', value);
        }

        public static IEnumerable<int> StringToList(string value)
        {
            if (value == null || value == string.Empty)
            {
                return null;
            }

            return value.Split(',').Select(i => Convert.ToInt32(i)); ;

        }
    }
}
