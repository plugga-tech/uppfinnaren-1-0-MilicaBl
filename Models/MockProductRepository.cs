// using System;

// namespace uppfinnaren_1_0_MilicaBl.Models;

// public class MockProductRepository : IProductRepository
// {
//     public IEnumerable<Product> AllProducts =>
//     new List<Product>
//     {
//         new Product{ProductId=1, Name="Shadow Reflection", Description="En spegel med en ram av mörkt trä. Perfekt för en dramatisk touch i moderna rum.", Price=8999, ImageUrl="img/mirror1.png", Category="Mirror"},
//         new Product{ProductId=2, Name="Shadowframe", Description="En minimalistisk spegel med en slät, matt svart ram. Stilren och lyxig.", Price=8999, ImageUrl="img/mirror2.png", Category="Mirror"},
//         new Product{ProductId=3, Name="Noir Vision", Description="En hög spegel med en djupbrunt ram. Perfekt för att skapa rymd och elegans.", Price=8599, ImageUrl="img/mirror3.png", Category="Mirror"},
//         new Product{ProductId=4, Name="Midnight Surface", Description="Ett matbord av mörkbetsad ek med en slät, oljad yta som reflekterar subtilt ljus", Price=15999, ImageUrl="img/table1.png", Category="Table"},
//         new Product{ProductId=5, Name="Raven's Rest", Description="Ett runt matbord med svart valnöt och tunna, guldfärgade metallben för en modern känsla.", Price=17999, ImageUrl="img/table2.png", Category="Table"},
//         new Product{ProductId=6, Name="Noir Edge", Description="Ett rektangulärt skrivbord av askträ med en mörk finish och kanter i polerad mässing.", Price=14999, ImageUrl="img/table3.png", Category="Table"},
//         new Product{ProductId=7, Name="Ebon Slab", Description="Ett massivt bord av svart alm med diskreta detaljer i mörkbrun marmor.", Price=19999, ImageUrl="img/table4.png", Category="Table"},
//         new Product{ProductId=8, Name="Velvet Throne", Description="En stol klädd i mörk sammet med en ram av svartbetsad ek. Lyxig och bekväm.", Price=15999, ImageUrl="img/chair1.png", Category="Chair"},
//         new Product{ProductId=9, Name="Noir Curve", Description="En elegant stol med en böjd rygg av mörk valnöt och klädd sits i kolsvart läder.", Price=14599, ImageUrl="img/chair2.png", Category="Chair"},
//         new Product{ProductId=10, Name="Raven Rest", Description="En modern stol med raka linjer, en stomme av mörkbetsat trä  och mjuka kuddar i djupt grått tyg.", Price=17999, ImageUrl="img/chair3.png", Category="Chair"},
//         new Product{ProductId=11, Name="Raven Wing", Description="En loungestol med bred sits av svartbetsad ask och detaljer i mässing.", Price=18999, ImageUrl="img/chair4.png", Category="Chair"},
//         new Product{ProductId=12, Name="Ebon Edge Board", Description="En lyxig skärbräda av mörkbetsad ek med släta kanter och en subtil oljad finish. Designad för både elegans och praktisk användning i köket.", Price=18999, ImageUrl="img/board1.png", Category="KitchenUtensils"},
//         new Product{ProductId=13, Name="Onyx Spoon", Description="En handgjord träslev av mörk valnöt med en mjukt polerad yta och gulddetaljer på handtaget.", Price=499, ImageUrl="img/spoon.png", Category="KitchenUtensils"},
//         new Product{ProductId=14, Name="Ebony Fork Duo", Description="Ett set med två handgjorda gafflar av svartbetsat trä, perfekta för servering av sallader eller pasta. Ergonomiska handtag och en polerad yta för en sofistikerad känsla.", Price=699, ImageUrl="img/fork.png", Category="KitchenUtensils"},
//         new Product{ProductId=15, Name="Ravenwood Board", Description="En skärbräda av mörk valnöt med fasade kanter och en oljad yta. Perfekt för att kombinera funktionalitet med sofistikerad design.", Price=8999, ImageUrl="img/board2.png", Category="KitchenUtensils"}
//     };
//     public Product? GetProductById(int productId) => AllProducts.FirstOrDefault(p => p.ProductId == productId);
//     public IEnumerable<Product> GetProductByCategory(string productCategory) => AllProducts.Where(p => p.Category.Equals(productCategory, StringComparison.OrdinalIgnoreCase));
// }
