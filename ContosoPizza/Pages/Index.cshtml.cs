using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
namespace ContosoPizza.Pages

{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string GeneratedName { get; set; } = string.Empty;
        string valittuika = "Lapset";

        public void OnGet(string valittu)
        {

            List<string> Naiset_lapsi = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\lapsi_nais_nimet.txt") };
            List<string> Naiset_nuori = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\nuori_nais_nimet.txt") };
            List<string> Naiset_vanha = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\vanha_nais_nimet.txt") };

            List<string> Miehet_lapsi = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\lapsi_mies_nimet.txt") };
            List<string> Miehet_nuori = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\nuori_mies_nimet.txt") };
            List<string> Miehet_vanha = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\vanha_mies_nimet.txt") };
            if (valittu == "Miehet")
            {
                if (valittuika == "Lapset")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet_lapsi);
                }
                if (valittuika == "Nuoret")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet_nuori);
                }
                if (valittuika == "Aikuiset")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet_vanha);
                }


            }
            if (valittu == "Naiset")
            {
                if (valittuika == "Lapset")
                {
                    GeneratedName = GenerateRandomMiehet(Naiset_lapsi);
                }
                if (valittuika == "Nuoret")
                {
                    GeneratedName = GenerateRandomMiehet(Naiset_nuori);
                }
                if (valittuika == "Aikuiset")
                {
                    GeneratedName = GenerateRandomMiehet(Naiset_vanha);
                }
            }
            /*GeneratedName = GenerateRandomNaiset(Naiset);
            GeneratedName = GenerateRandomMiehet(Miehet);*/
        }
        private string GenerateRandomMiehet(List<string> Miehet)
        {
            Random random = new Random();

            string Miehet1 = Miehet[random.Next(Miehet.Count)];

            return $"{Miehet1}";
        }
        private string GenerateRandomNaiset(List<string> Naiset)
        {
            Random random = new Random();

            string Naiset1 = Naiset[random.Next(Naiset.Count)];

            return $"{Naiset1}";
        }

    }
}