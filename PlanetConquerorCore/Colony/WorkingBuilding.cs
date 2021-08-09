using System.Collections.Generic;
using PlanetConquerorCore.Person;
namespace PlanetConquerorCore.Colony {
    public class WorkingBuilding : Building {
        public JobType TypeOfWorkerWanted;
        public int AmountOfWorkedWanted;
        private List<Colonist> Workers = new List<Colonist>();
    }
}
