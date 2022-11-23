using Shop;

var catalog = new Catalog();

catalog.AppendProduct("Книга 1", "А Labyrinth", 15.3);
catalog.AppendProduct("Книга 2", "Б Labyrinth", 20);
catalog.AppendProduct("Телефон", "PaperClub", 10.5);
catalog.AppendProduct("Двигатель", "Autos", 99.9);
catalog.AppendProduct("Мышь", "Купи мышь и не жалуйся", 20.3);
catalog.AppendProduct("Стол", "IKEA", 54.9);
catalog.AppendProduct("Ракета", "SpaceX", 1000);

var newProduct = new Product("Остров", "YourIslands LLC", 99999.99);
catalog.AppendProduct(newProduct);


// for (var index = 0; index < 8; index++)
// {
//     catalog.AppendProduct(
//         Console.ReadLine(),
//         Console.ReadLine(),
//         double.Parse(Console.ReadLine())
//     );
// }


catalog.Sort(product => product.Name);
catalog.Print();

// catalog.Sort(product => product.ShopName);
// catalog.Print();

// catalog.SortByPrice();
// catalog.Print();

catalog.SearchByProductName("Двигатель"); // 1 product in result

catalog.SearchByProductName("Книга"); // 2 products in result

catalog.SearchByProductName("Такого точно нет и не будет в наличии"); // Error


