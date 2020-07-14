using system;
namespace Product
{
	 class Product
    {
        internal int productId;
		internal string brand;
		internal string productName;
		internal double price;
        internal string color;

        internal void Display()
        {
            Console.WriteLine("ID:" + productId + "Brand: " + brand + "Name: " + productName + "Rs." + price + "Colour: " + color);
        }
    }
	class ProductModel
	{
		static void main(string[] args)
		{
			Product product1;
			product1 = new Product();
			product1.productID = 1;
			Product1.brand = "Boat";
			product1.productName = "Head Phones";
			product1.price = 2000;
			product1.color = "Red";
			
			product1.Display();
		}
	}
}