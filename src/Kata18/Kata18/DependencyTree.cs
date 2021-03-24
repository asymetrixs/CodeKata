using System;
using System.Collections.Generic;
using System.Linq;

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

            // Will hold all dependencies
            var dependencies = new HashSet<char>();

            // Get direct dependencies
            var directDependencies = this._dependencies[component];

            // Loop through dependencies and add indirect dependencies
            for (int i = 0; i < directDependencies.Length; i++)
            {
                _recursiveLookup(directDependencies[i]);
            }

            // Sort and return
            return dependencies.OrderBy(d => d).ToArray();

            /*
             * Using inline-function functionality for resolution
             */
            void _recursiveLookup(char component)
            {
                // Add dependency if not already present
                if (!dependencies.Contains(component))
                {
                    dependencies.Add(component);
                }

                // Get dependencies of this component
                if (_dependencies.ContainsKey(component))
                {
                    var componentDependencies = _dependencies[component];

                    // Loop through dependencies
                    for (int i = 0; i < componentDependencies.Length; i++)
                    {
                        // Recursive lookup
                        _recursiveLookup(componentDependencies[i]);
                    }
                }
            }
        }
    }
}
