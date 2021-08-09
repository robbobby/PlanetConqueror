namespace PlanetConquerorCore {
    public class Resource {
        public ResourceType ResourceType { get; private set; }
        public int Amount { get; private set; }
        
        public Resource(ResourceType _resourceType, int _amount) {
            ResourceType = _resourceType;
            Amount = _amount;
        }

        private void UseResource(int _amount) {
            if (Amount - _amount < 0)
                Amount = -_amount;
            else
                Amount = 0;
        }
    }
}
