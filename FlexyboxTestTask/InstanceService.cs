
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlexyboxTestTask
{
    public static class InstanceService<T> 
    {
        public static IEnumerable<T> GetInstances()
        {
            var assembly = typeof(T).Assembly;

            var types = assembly.GetTypes().Where(t => t.BaseType == typeof(T)).ToList();

            return types.Select(t => (T) Activator.CreateInstance(t)).ToList();
        }
    }
}
