using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tangy.Extensions
{
    public  static class IEnumerableExtension
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> items, int selectedValue)
        {
            //return each of the item exist within the IEnumerable
            return from item in items
                   select new SelectListItem
                   {
                       Text = item.GetPropertyvalue("Name"),
                       Value = item.GetPropertyvalue("Id"),
                       Selected = item.GetPropertyvalue("Id").Equals(selectedValue.ToString())

                   };

        }
    }
}
