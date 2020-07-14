using system;
namespace Product
{
	 class Product
    {
        int productId;
		string brand;
		string productName;
		double price;
        string color;

        void Display()
        {
            Console.WriteLine("ID:" + productId + "Brand: " + brand + "Name: " + productName + "Rs." + price + "Colour: " + color);
        }
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