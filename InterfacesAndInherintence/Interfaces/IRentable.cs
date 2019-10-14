namespace InterfacesAndInherintence
{
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}
