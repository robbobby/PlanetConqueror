using System.Collections.Generic;
using PlanetConquerorCore.Person;

namespace PlanetConquerorCore.Colony {
    public class Colony {
        public string Name { get; private set; }
        public int Money { get; private set; } = 0;
        public List<Resource> ResourcesCollected { get; private set; }
        public List<Colonist> People { get; private set; } = new List<Colonist>();
        public List<Building> Buildings { get; private set; } = new List<Building>();
        
        public Colony(string _name, int _money) {
            Name = _name;
            Money = _money;
            InitResourceList();
        }
        private void InitResourceList() {
            ResourcesCollected = new List<Resource>();
            // TODO: loop through enum of resource type and make initial ResourcesCollected list
        }
    }
    
}
