using System;
using PlanetConquerorCore.Colony;
using Xunit;
namespace TestProject1.ColonyTests {
    public class ColonyTest {
        private Colony colony;

        public ColonyTest() {
            this.colony = new Colony("New Colony", 100_000);
        }
        
        [Fact] public void CanGetName() {
            Assert.Equal(colony.Name, "New Colony");
        }

        [Fact] public void CanGetMoney() {
            Assert.Equal(100_000, colony.Money);
        }

        [Fact] public void ResourcesCollectionHasAllResources() {
            
        }
    }
}
