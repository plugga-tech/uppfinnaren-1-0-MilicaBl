using System;

namespace uppfinnaren_1_0_MilicaBl.Models;

public class MockCategoryRepository : ICategoryRepository
{
  private readonly List<Category> _categories = new List<Category>
    {
        new Category
        {
            Name="Speglar",
            Description="Våra speglar kombinerar tidlös elegans med modern design, skapade för att framhäva varje rum med en unik trästruktur.",
            AdditionalDescription="Varje spegel är handgjord och omsorgsfullt utformad för att ge en känsla av rymd och ljus samtidigt som den bevarar den naturliga skönheten i träet.",
            ImageUrl="img/mirror1.png",
            Link="/product/byCategory?category=Mirror",
            IsRowReversed=false
        },
          new Category
        {
            Name="Stolar",
            Description="Tillverkade av hållbart trä, våra stolar är både ett praktiskt och vackert inslag i ditt hem, perfekta för både matbordet och som en stilren sittplats.",
            AdditionalDescription="Från minimalistiska linjer till mer dekorativa detaljer – våra stolar ger varje plats ett personligt och lyxigt uttryck.",
            ImageUrl="img/chair4.png",
            Link="/product/byCategory?category=Chair",
            IsRowReversed=true
        },
          new Category
        {
            Name="Bord",
            Description="Våra bord är skapade för att vara både praktiska och konstnärliga, och passar perfekt i alla rum för att skapa en naturlig och inbjudande atmosfär.",
            AdditionalDescription="Varje bord är handgjort och tillverkat med noggrant utvalda träslag, vilket ger en unik karaktär och hållbarhet som håller i många år.",
            ImageUrl="img/table2.png",
            Link="/product/byCategory?category=Table",
            IsRowReversed=false
        },
          new Category
        {
            Name="Köksredskap",
            Description="Våra handgjorda köksredskap kombinerar traditionellt hantverk med funktionell design, perfekta för varje kök.",
            ImageUrl="img/board1.png",
            Link="/product/byCategory?category=KitchenUtensils",
            IsRowReversed=true
        }
    };
  public IEnumerable<Category> GetAllCategories() => _categories;
}
