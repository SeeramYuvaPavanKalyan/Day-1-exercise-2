using system;
namespace Product
{
	 class Product
    {
        internal int productId;
        internal string productName;
        internal string brand;
        internal double price;
        internal string color;

        internal void Display()
        {
            Console.WriteLine("ID:" + productId + "Brand: " + brand + "Name: " + productName + "Rs." + price + "Colour: " + color);
        }
		internal Product()
        {
            Console.WriteLine("Empty Object Initialization");
        }
        internal Product(int productId, string brand, string productName, double price, string color)
        {
            Console.WriteLine("Object Initialized");
            this.productId = productId;
            this.brand = brand;
            this.productName = productName;
            this.color = color;
            this.price = price;
                 
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

            Product product2 = new product(2, "HP", "Pendrive", 500, "red");
            product2.Display();

			Product product1 = new product(3, "Samsung", "SDcard", 300, "black");
			product1.Display();
		}
	}
}