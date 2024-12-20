using System;

namespace uppfinnaren_1_0_MilicaBl.Models.About;

public class AboutUsRepository : IAboutUsRepository
{
    public AboutUs GetAboutUs()
    {
        return new AboutUs
        {
            CompanyName = "The Wood Atelier",
            AboutCompanyContent = "The wood Atelier grundades med en passion för trä och hantverk. Vår vision är att skapa handgjorda produkter av högsta kvalitet som både hyllar traditionellt hantverk och kombinerar modern design. Företaget startades för att ge människor möjlighet att äga och använda unika och hållbara träprodukter, från möbler till mindre accessoarer. Vi arbetar endast med de bästa materialen och strävar efter att varje produkt vi skapar ska vara både funktionell och estetiskt tilltalande.Vi tror på långsiktig hållbarhet och arbetar därför aktivt för att minimera vår påverkan på miljön. Alla våra träprodukter är noggrant utvalda, behandlade och bearbetade för att säkerställa att de håller länge och åldras med värdighet. Vårt fokus ligger på detaljer och kvalitet, vilket gör att våra produkter passar perfekt i både moderna hem och traditionella miljöer.",
            AboutArtistContent = "Emma Larsson  är en passionerad uppfinnare och konstnär med över 10 års erfarenhet inom träbearbetning och design. Hennes intresse för trä började tidigt, då hon fascinerades av naturens egna material och deras mångsidighet. Efter att ha utbildat sig inom träslöjd och konst, beslutade Emma att starta eget och förverkliga sina idéer genom att skapa handgjorda träprodukter som är både funktionella och konstnärliga. Som en kreativ tänkare har hon alltid strävat efter att hitta nya sätt att kombinera traditionella hantverkstekniker med moderna idéer. Detta har lett till en unik stil som blandar det rustika med det eleganta. Emma ser varje produkt som ett konstverk, där varje detalj är viktig för att skapa en harmonisk och hållbar helhet.Under sin karriär har Emma fått erkännande för sina innovativa designs och har blivit en viktig aktör i branschen. Hon har arbetat med allt från små detaljerade träföremål till större möbelprojekt, alltid med samma mål: att skapa produkter som står för kvalitet, hållbarhet och konstnärlig skönhet.Emma Larsson fortsätter att utforska nya sätt att arbeta med trä och hoppas kunna inspirera andra att uppskatta materialets naturliga skönhet och mångsidighet.",
            ArtistImageUrl = "/img/decoration/artist.png",
            ArtistName = "Emma Larsson"
        };
    }
}
