using System;
using Microsoft.EntityFrameworkCore;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, Name = "Shadow Reflection", Description = "En spegel med en ram av mörkt trä. Perfekt för en dramatisk touch i moderna rum.", Price = 8999, ImageUrl = "img/mirror1.png", CategoryId = 1 },
            new Product { ProductId = 2, Name = "Shadowframe", Description = "En minimalistisk spegel med en slät, matt svart ram. Stilren och lyxig.", Price = 8999, ImageUrl = "img/mirror2.png", CategoryId = 1 },
            new Product { ProductId = 3, Name = "Noir Vision", Description = "En hög spegel med en djupbrunt ram. Perfekt för att skapa rymd och elegans.", Price = 8599, ImageUrl = "img/mirror3.png", CategoryId = 1 },
            new Product { ProductId = 4, Name = "Luna Timber", Description = "En rund spegel med en naturlig träram. En tidlös design som skapar värme och harmoni i hemmet.", Price = 8599, ImageUrl = "img/mirror4.png", CategoryId = 1 },
            new Product { ProductId = 5, Name = "Midnight Surface", Description = "Ett matbord av mörkbetsad ek med en slät, oljad yta som reflekterar subtilt ljus", Price = 15999, ImageUrl = "img/table1.png", CategoryId = 3 },
            new Product { ProductId = 6, Name = "Raven's Rest", Description = "Ett runt matbord med svart valnöt och tunna, guldfärgade metallben för en modern känsla.", Price = 17999, ImageUrl = "img/table2.png", CategoryId = 3 },
            new Product { ProductId = 7, Name = "Noir Edge", Description = "Ett rektangulärt skrivbord av askträ med en mörk finish och kanter i polerad mässing.", Price = 14999, ImageUrl = "img/table3.png", CategoryId = 3 },
            new Product { ProductId = 8, Name = "Ebon Slab", Description = "Ett massivt bord av svart alm med diskreta detaljer i mörkbrun marmor.", Price = 19999, ImageUrl = "img/table4.png", CategoryId = 3 },
            new Product { ProductId = 9, Name = "Velvet Throne", Description = "En stol klädd i mörk sammet med en ram av svartbetsad ek. Lyxig och bekväm.", Price = 15999, ImageUrl = "img/chair1.png", CategoryId = 2 },
            new Product { ProductId = 10, Name = "Noir Curve", Description = "En elegant stol med en böjd rygg av mörk valnöt och klädd sits i kolsvart läder.", Price = 14599, ImageUrl = "img/chair2.png", CategoryId = 2 },
            new Product { ProductId = 11, Name = "Raven Rest", Description = "En modern stol med raka linjer, en stomme av mörkbetsat trä  och mjuka kuddar i djupt grått tyg.", Price = 17999, ImageUrl = "img/chair3.png", CategoryId = 2 },
            new Product { ProductId = 12, Name = "Raven Wing", Description = "En loungestol med bred sits av svartbetsad ask och detaljer i mässing.", Price = 18999, ImageUrl = "img/chair4.png", CategoryId = 2 },
            new Product { ProductId = 13, Name = "Ebon Edge Board", Description = "En lyxig skärbräda av mörkbetsad ek med släta kanter och en subtil oljad finish. Designad för både elegans och praktisk användning i köket.", Price = 18999, ImageUrl = "img/board1.png", CategoryId = 4 },
            new Product { ProductId = 14, Name = "Onyx Spoon", Description = "En handgjord träslev av mörk valnöt med en mjukt polerad yta och gulddetaljer på handtaget.", Price = 499, ImageUrl = "img/spoon.png", CategoryId = 4 },
            new Product { ProductId = 15, Name = "Ebony Fork Duo", Description = "Ett set med två handgjorda gafflar av svartbetsat trä, perfekta för servering av sallader eller pasta. Ergonomiska handtag och en polerad yta för en sofistikerad känsla.", Price = 699, ImageUrl = "img/fork.png", CategoryId = 4 },
            new Product { ProductId = 16, Name = "Ravenwood Board", Description = "En skärbräda av mörk valnöt med fasade kanter och en oljad yta. Perfekt för att kombinera funktionalitet med sofistikerad design.", Price = 8999, ImageUrl = "img/board2.png", CategoryId = 4 }
        )
        ;
        modelBuilder.Entity<Category>().HasData(
         new Category
         {
             Name = "Speglar",
             CategoryId = 1,
             Description = "Våra speglar kombinerar tidlös elegans med modern design, skapade för att framhäva varje rum med en unik trästruktur.",
             AdditionalDescription = "Varje spegel är handgjord och omsorgsfullt utformad för att ge en känsla av rymd och ljus samtidigt som den bevarar den naturliga skönheten i träet.",
             ImageUrl = "img/mirror1.png",
             IsRowReversed = false
         },
         new Category
         {
             Name = "Stolar",
             CategoryId = 2,
             Description = "Tillverkade av hållbart trä, våra stolar är både ett praktiskt och vackert inslag i ditt hem, perfekta för både matbordet och som en stilren sittplats.",
             AdditionalDescription = "Från minimalistiska linjer till mer dekorativa detaljer – våra stolar ger varje plats ett personligt och lyxigt uttryck.",
             ImageUrl = "img/chair4.png",
             IsRowReversed = true
         },
         new Category
         {
             Name = "Bord",
             CategoryId = 3,
             Description = "Våra bord är skapade för att vara både praktiska och konstnärliga, och passar perfekt i alla rum för att skapa en naturlig och inbjudande atmosfär.",
             AdditionalDescription = "Varje bord är handgjort och tillverkat med noggrant utvalda träslag, vilket ger en unik karaktär och hållbarhet som håller i många år.",
             ImageUrl = "img/table2.png",
             IsRowReversed = false
         },
         new Category
         {
             Name = "Köksredskap",
             CategoryId = 4,
             Description = "Våra handgjorda köksredskap kombinerar traditionellt hantverk med funktionell design, perfekta för varje kök.",
             ImageUrl = "img/board1.png",
             IsRowReversed = true
         }
        );
        // Define relation betweeen Product and Category
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)  // A product has one category
            .WithMany(c => c.Products)  // A category has many products
            .HasForeignKey(p => p.CategoryId);  // Foreign key from Product to Category
    }
}
