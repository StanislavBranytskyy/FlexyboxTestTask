
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlexyboxTestTask
{
    public sealed class InstanceService<T>
    {
        private static IEnumerable<T> _instances;

        public static IEnumerable<T> GetInstances()
        {
            if (_instances == null)
            {
                var assembly = typeof(T).Assembly;

                var types = assembly.GetTypes().Where(t => t.BaseType == typeof(T)).ToList();

                _instances = types.Select(t => (T)Activator.CreateInstance(t)).ToList();
            }

            return _instances;
        }
    }
}
