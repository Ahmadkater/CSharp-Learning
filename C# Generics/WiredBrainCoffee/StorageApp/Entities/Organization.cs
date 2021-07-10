

namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organization : Entity
    {
        public string Name { get; set; }

        public override string ToString() => $"Id:{Id}, Name:{Name} ";
    }

}