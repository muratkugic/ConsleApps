namespace InterfacesAndInherintence
{
    public class PenModel : InventoryItemModel, IPurchasable
    {
        public decimal Price { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            System.Console.WriteLine("Pen Purchased");
        }
    }
}
