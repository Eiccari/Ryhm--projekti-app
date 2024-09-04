using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Contoso.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string GeneroiName { get; set; } = string.Empty;

        public void OnGet(string valittu, string valittuika)
        {
            // Lists of names
            List<string> Naiset_lapsi = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\lapsi_nais_nimet.txt") };
            List<string> Naiset_nuori = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\nuori_nais_nimet.txt") };
            List<string> Naiset_vanha = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\vanha_nais_nimet.txt") };

            List<string> Miehet_lapsi = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\lapsi_mies_nimet.txt") };
            List<string> Miehet_nuori = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\nuori_mies_nimet.txt") };
            List<string> Miehet_vanha = new List<string> { System.IO.File.ReadAllText(@"C:\Users\Lari\OneDrive - SASKY koulutuskuntayhtymä\Tiedostot\GitHub\Ryhma-projekti-app\ContosoPizza\pages\vanha_mies_nimet.txt") };

            // Generate a random name based on the selected gender
            if (valittu == "Miehet")
            {
                if (valittuika == "Lapset")
                {
                    GeneroiName = GenerateRandomName(Miehet_lapsi);
                }
                if (valittuika == "Nuoret")
                {
                    GeneroiName = GenerateRandomName(Miehet_nuori);
                }
                if (valittuika == "Aikuiset")
                {
                    GeneroiName = GenerateRandomName(Miehet_vanha);
                }

            }
            else if (valittu == "Naiset")
            {
                if (valittuika == "Lapset")
                {
                    GeneroiName = GenerateRandomName(Naiset_lapsi);
                }
                if (valittuika == "Nuoret")
                {
                    GeneroiName = GenerateRandomName(Naiset_nuori);
                }
                if (valittuika == "Aikuiset")
                {
                    GeneroiName = GenerateRandomName(Naiset_vanha);
                }
            }
        }

        private string GenerateRandomName(List<string> names)
        {
            Random random = new Random();
            return names[random.Next(names.Count)];
        }
    }
}

