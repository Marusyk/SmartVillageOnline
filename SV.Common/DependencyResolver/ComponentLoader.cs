﻿using System;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Reflection;
using System.Text;
using DependencyResolution.Implementations;
using DependencyResolution.Interfaces;
using Microsoft.Practices.Unity;

namespace DependencyResolution
{
    public class ComponentLoader
    {
        public static void LoaderContainer(IUnityContainer container, string path, string pattern)
        {
            var dirCat = new DirectoryCatalog(path, pattern);
            var importDef = BuildImportDefinition();
            try
            {
                using (var aggregateCatalog = new AggregateCatalog())
                {
                    aggregateCatalog.Catalogs.Add(dirCat);
                    using (var componsitionContainer = new CompositionContainer(aggregateCatalog))
                    {
                        var exports = componsitionContainer.GetExports(importDef);
                        var modules =
                            exports.Select(export => export.Value as IComponent).Where(m => m != null);
                        var registerComponent = new RegisterComponent(container);
                        foreach (var module in modules)
                        {
                            module.SetUp(registerComponent);
                        }
                    }
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                var builder = new StringBuilder();
                foreach (var loaderException in ex.LoaderExceptions)
                {
                    builder.AppendFormat($"{loaderException.Message}\n");
                }
                throw new TypeLoadException(builder.ToString(), ex);
            }
        }

        private static ImportDefinition BuildImportDefinition() =>
            new ImportDefinition(def => true, typeof(IComponent).FullName, ImportCardinality.ZeroOrMore, false, false);

    }
}