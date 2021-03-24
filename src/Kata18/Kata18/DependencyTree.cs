using System;
using System.Collections.Generic;

namespace CodeKata.Kata18
{
    public class DependencyTree
    {
        /// <summary>
        /// Dictionary holding the dependencies
        /// </summary>
        private Dictionary<char, char[]> _dependencies;

        public DependencyTree()
        {
            this._dependencies = new();
        }

        /// <summary>
        /// Count of component entries
        /// </summary>
        public int Count => _dependencies.Count;

        /// <summary>
        /// Adds a record to the dependency tree
        /// </summary>
        /// <param name="component">Component</param>
        /// <param name="dependencies">Dependencies of this component</param>
        public void Add(char component, char[] dependencies)
        {
            if(!this._dependencies.ContainsKey(component))
            {
                this._dependencies.Add(component, dependencies);
            }
        }

        /// <summary>
        /// Resolves dependencies of a component
        /// </summary>
        /// <param name="component">Component</param>
        /// <returns></returns>
        public char[] ResolveDependenciesOf(char component)
        {
            if(!this._dependencies.ContainsKey(component))
            {
                return new char[] { };
            }

            throw new NotImplementedException();
        }
    }
}
