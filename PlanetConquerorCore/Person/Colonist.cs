using System.Collections.Generic;
using PlanetConquerorCore.Colony;
namespace PlanetConquerorCore.Person {
    public class Colonist {
        public string Name { get; private set; }
        public Dictionary<Skill, int> Skills { get; private set; }
        public Building Job { get; private set; } 
        public Building Home { get; private set; }
        public List<JobType> Experience { get; private set; }
    }
    public enum Skill {
        Farming,
        Mining,
        Sciencing,
        Inventing,
        Building,
        ResourceManagement,
    }
}
