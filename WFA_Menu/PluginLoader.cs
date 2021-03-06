﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Menu
{
    public class PluginLoader<T>
    {
        private CompositionContainer _Container;

		[ImportMany]
		public IEnumerable<T> Plugins
		{
			get;
			set;
		}

        public PluginLoader(string path)
		{
			DirectoryCatalog directoryCatalog = new DirectoryCatalog(path);
			var catalog = new AggregateCatalog(directoryCatalog);
			_Container = new CompositionContainer(catalog);
			_Container.ComposeParts(this);
		}
    }
}
