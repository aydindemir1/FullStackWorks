using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    using System;
    using System.Collections.Generic;

    public static class ListExtensions
    {
        public static void ReverseOrder<T>(this List<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            list.Reverse();
        }

        public static void SortBy<T>(this List<T> list, Comparison<T> comparison)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (comparison == null)
            {
                throw new ArgumentNullException(nameof(comparison));
            }

            list.Sort(comparison);
        }
    }

}
