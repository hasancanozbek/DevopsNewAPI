using Microsoft.AspNetCore.Mvc;

namespace DevopsNewAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokesController : ControllerBase
    {
        private readonly List<string> jokes;
        public JokesController()
        {
            jokes = new List<string>
            {
                "Türkiye’nin en yeni şehri hangisidir?   Nevşehir",
                "Gülen ördeğe ne denir?   Kıkır-Duck",
                "Örümcek adam ağ atamıyormuş neden?   Çünkü ağ bağlantısı kopmuş",
                "Hobbit katliamına ne denir?   Ufak tefek cinayetler",
                "Seyahat anılarını yazan Assasin'e ne denir?   Gezio",
                "Harry Potter'da temizlik takıntısı olan binaya hangisidir?   Siliverin",
                "Çok tuzlu yemek yapan Japon aşçıya ne denir?   Tuzubasa",
                "İstanbul'da saç ekim kliniğinde karşılaşan iki kişi birbirine ne demiştir?\nمرحبا يا صدي   ",
                "Sevgili kavgalarında danıştığımız en yakın arkadaşa ne denir?   Trip advisor",
                "Atalarımızın oynadığı Rocket League oyununa ne denir?   Kutadgu Bi-League",
                "Bruce Lee nin askerlik sevmeyen kuzeninin adı nedir?   Bedel Lee",
                "Böbreklerdeki aşırı sıkışmanın nedeni nedir?   İd.rar",
                "Hiç sevgilisi olmayan Mortal Combat karakteri hangisidir?   Sap-Zero",
                "Avrupadan ülkemize saç ektirmeye gelmeye nedir?   Saçlı seferi"
            };
        }

        public IActionResult Get()
        {
            var random = new Random();
            var index = random.Next(1, 15) - 1;
            var jokeOfTheDay = jokes[index];
            return Ok(jokeOfTheDay);
        }
    }
}
