namespace InterfacesAndInherintence
{
    public class NotebookModel : InventoryItemModel, IPurchasable
    {
        public decimal Price { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            System.Console.WriteLine("Notebook Purchased");
        }
    }
}
