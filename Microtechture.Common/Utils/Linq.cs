using System;
using System.Collections.Generic;
using System.Text;

namespace Microtechture.Common.Utils
{
    public class Linq
    {
        public static IEnumerable<TEntity> TakeSourceUnmatch<TEntity, TKey>(IEnumerable<TEntity> source, IEnumerable<TEntity> target, Func<TEntity, TKey> keySelector) where TEntity : class
        {
            var excludedKeys = new HashSet<TKey>(target.Select(keySelector));

            return source.Where(a => !excludedKeys.Contains(keySelector(a)));
        }
    }
}
