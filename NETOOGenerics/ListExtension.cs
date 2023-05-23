using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NETOOGenerics
{
    public static class ListExtension
    {

        public static TElement NewFirst<TElement>(this IEnumerable<TElement> list, Predicate<TElement> predicate)
        {
            foreach (TElement element in list)
            {
                if (predicate(element))
                {
                    return element;
                }
            }
            throw new ArgumentException();
        }

        public static TValue? DicoFirst<TKey, TValue>(this Dictionary<TKey, TValue> dico, Predicate<TKey> predicate)
        {
            foreach(TKey key in dico.Keys)
            {
                if (predicate(key))
                {
                    return dico[key];
                }
            }

            return default(TValue);
        }
    }
}
