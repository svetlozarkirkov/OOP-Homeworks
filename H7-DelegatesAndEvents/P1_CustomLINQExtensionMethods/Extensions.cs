using System;
using System.Collections.Generic;
using System.Linq;

namespace P1_CustomLINQExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>
            (this IEnumerable<T> collection, 
            Func<T, bool> predicate)
        {
            IEnumerable<T> filteredCollection = collection.Where(elem => !predicate(elem));
            
            //var filteredCollection = new List<T>();
            //foreach (var element in collection)
            //{
            //    if (!predicate(element))
            //    {
            //        filteredCollection.Add(element);
            //    }
            //}

            return filteredCollection;
        }

        public static TSelector Max<TSource, TSelector>
            (this IEnumerable<TSource> collection, 
            Func<TSource, TSelector> selector)
        {
            //Console.WriteLine(typeof(TSelector));

            return default(TSelector);
        }
    }
}