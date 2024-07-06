using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> WhereGreaterThan<T>(this IEnumerable<T> source, T threshold) where T : IComparable<T>
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            foreach (var item in source)
            {
                if (item.CompareTo(threshold) > 0)
                {
                    yield return item;
                }
            }
        }
    }

}
