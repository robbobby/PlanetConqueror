using System.Collections.Generic;
namespace PlanetConquerorCore.Planet {
    public class Planet {
        public string Name { get; private set; }
        private List<Resource> ResourcesAvailable { get; } = new List<Resource>();
        
        public Planet(string _name) {
            Name = _name;
        }

        public void AddResource(Resource _resource) {
            ResourcesAvailable.Add(_resource);
        }
    }
}
