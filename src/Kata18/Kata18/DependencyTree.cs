using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            if (!this._dependencies.ContainsKey(component))
            {
                this._dependencies.Add(component, dependencies);
            }
        }

        /// <summary>
        /// Resolves dependencies of a component
        /// </summary>
        /// <param name="component">Component</param>
        /// <returns>List of dependencies</returns>
        public char[] ResolveDependenciesOf(char component)
        {
            if (!this._dependencies.ContainsKey(component))
            {
                return new char[] { };
            }

            // Will hold all dependencies
            var dependencies = new HashSet<char>();

            // Get direct dependencies
            var directDependencies = this._dependencies[component];

            // Work in parallel on dependencies and add indirect dependencies
            Parallel.ForEach(directDependencies, (item) => _recursiveLookup(item));

            // Sort and return
            return dependencies.OrderBy(d => d).ToArray();

            /*
             * Using inline-function functionality for resolution
             */
            void _recursiveLookup(char component)
            {
                // Add dependency if not already present
                lock (dependencies)
                {
                    if (!dependencies.Contains(component))
                    {
                        dependencies.Add(component);
                    }
                    else
                    {
                        // Return if component was already added
                        // to prevent infinite circular lookups
                        return;
                    }
                }

                // Get dependencies of this component
                if (_dependencies.ContainsKey(component))
                {
                    var componentDependencies = _dependencies[component];

                    // Work in parallel on dependencies and add indirect
                    // dependencies with recursive lookup
                    Parallel.ForEach(componentDependencies, (item) => _recursiveLookup(item));
                }
            }
        }
    }
}
