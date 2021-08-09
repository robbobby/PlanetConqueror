using System.Collections.Generic;
using PlanetConquerorCore.Person;
namespace PlanetConquerorCore.Colony {
    public abstract class Building {
        public BuildingType Type { get; private set; }
    }

    public class Housing : Building {
        private List<Colonist> Occupants = new List<Colonist>();
    }

    public class WorkingBuilding : Building {
        public JobType TypeOfWorkerWanted;
        public int AmountOfWorkedWanted;
        private List<Colonist> Workers = new List<Colonist>();
    }
    public enum JobType {
        Farmer,
        Miner,
        Scientist,
        Builder,
        Entertainer,
    }
}
