namespace LambdaLinq.Extensions
{
    using System.Collections.Generic;
    public static class IEnumerableExtension
    {
        public static T sum<T>(this IEnumerable<T> collection) where T: struct 
        {
            T sum =(dynamic) 0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T product<T>(this IEnumerable<T> collection) where T : struct
        {
            T sum = (dynamic)1;
            foreach (var item in collection)
            {
                sum *= (dynamic)item;
            }
            return sum;
        }

    }
}
