namespace InterfacesAndInherintence
{
    public class BookModel : InventoryItemModel, IRentable, IPurchasable
    {
        public decimal LateReturnFee { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            System.Console.WriteLine("Book Purchased");
        }

        public void Rent()
        {
            QuantityInStock -= 1;
            System.Console.WriteLine("Book Rented");
        }

        public void ReturnRental()
        {
            QuantityInStock += 1;
            System.Console.WriteLine("Book Returned");
        }
    }
}
