using System;
using System.Collections.Generic;
using System.Linq;

namespace DPA_Musicsheets.Managers
{
    public class LoaderFactory
    {
        private readonly Dictionary<string, Loader> _loaderTypes;

        public LoaderFactory()
        {
            _loaderTypes = new Dictionary<string, Loader>();
            var loaders = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(n => typeof(Loader).IsAssignableFrom(n) && !n.IsAbstract).ToList();

            foreach (var loader in loaders)
            {
                var handler = (Loader)Activator.CreateInstance(loader);
                _loaderTypes.Add(handler.Extension, handler);
            }
        }

        public Loader GetLoader(string extension)
        {
            return _loaderTypes[extension];
        }
    }
}