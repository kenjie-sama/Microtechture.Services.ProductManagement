using System;
using System.Collections.Generic;
using System.Text;

namespace Microtechture.Common.Utils
{
    public class Linq
    {
        public static IEnumerable<T> UnmatchedOnSource<T, K>(IEnumerable<T> source, IEnumerable<T> target, Func<T, K> keySelector) where T : class
        {
            var excludedKeys = new HashSet<K>(target.Select(keySelector));

            return source.Where(a => !excludedKeys.Contains(keySelector(a)));
        }
    }
}
