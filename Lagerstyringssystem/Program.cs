using Lagerstyringssystem;

var storage = new Storage();
storage.AddProduct(new Electronics("IPhone", 18999.99, 0));
storage.AddProduct(new Electronics("Lenovo ThinkPad", 35490, 36));
storage.AddProduct(new Food("Grandiosa", 64, new DateOnly(2024,06,30)));
storage.AddProduct(new Food("Helmelk", 19.50, new DateOnly(2023,12, 20)));
storage.AddProduct(new Clothes("Olabukse", 1200, ClothesSizes.Xxxl));
storage.AddProduct(new Clothes("Hettegenser", 900, ClothesSizes.M));
storage.RemoveProduct(0);
storage.ShowProducts();