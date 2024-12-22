# Uppfinnaren - The Wood Atelier

Detta är en dynamisk webbapplikation utvecklad med ASP.NET Core MVC. Applikationen är designad för att visa upp handgjorda möbler och träprodukter, kategoriserade i olika produktgrupper. Besökare kan utforska produkterna genom olika kategorisidor och se detaljer för varje produkt. Applikationen använder en klassbaserad datastruktur (Category, Product) tillsammans med ett repository-mönster (ICategoryRepository, IProductRepository), vilket gör hanteringen av data både flexibel och skalbar. Repositories fungerar som en abstraktion för dataåtkomst.Detta möjliggör att data kan hämtas från olika källor (t.ex. en databas, API, eller mockad data) utan att ändra logiken i applikationen. Mock-klasser MockCategoryRepository och MockCategoryRepository används för att simulera data under utveckling. Om applikationen senare ska använda en databas, kan det enkelt bytas ut mot en implementation som hämtar data från databasen. Om nya egenskaper behövs (t.ex. lagerstatus), kan dessa läggas till i Category/Product klasser och hanteras via samma repository interface.

## Hur man startar applikationen
Förkrav
 -.NET SDK installerad på din dator.
 
 1.**Klona eller ladda ner projektet**
   ```bash
   git clone https://github.com/plugga-tech/uppfinnaren-1-0-MilicaBl.git
   ````
2.**Öppna en terminal i projektmappen** 

3.**Kör följande komando för att starta programmet**
 ```bash
   dotnet run
   ````
4.**Öppna applikationen i webbläsaren**

 Öppna webbadressen som visas i terminalen(exempelvis http://localhost:5000)

## Funktioner  
- Visa alla produkter genom att navigera till produkt sidan.
- Klicka på en produkt för att se mer information.   
- Visa produkter baserade på deras kategori, såsom speglar, stolar, bord och köksredskap genom att klicka på "Visa alla våra ..." på startsidan.
- Visa kontaktinformation på kontaktsidan.

## Teknologi  
- **Backend:** ASP.NET Core MVC  
- **Frontend:** HTML, CSS, Razor Views  
- **Mock-data:** Användning av mock-repositories för att simulera data.
- Bilder är AI genererade

## Branch Uppfinnaren-2
Denna branch innehåller förbättringar och nya funktioner som inte finns i main:
- **Databasanslutning:** Mockrepositories har ersatts med en EF InMemory databas. 
- **Relationshantering:** Produkter är nu kopplade till kategorier med en foreignkey CategoryId.
- **Material:** Produkter är nu kopplade till Material och det finns en materialsektion på startsidan för att filtrera produkter på material.
- **Om oss sida**

##För att testa Uppfinnaren-2 
**Byt till branchen med :**
 ```bash
   git checkout uppfinnaren-2
 ````
