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

        public void OnGet(string valittu, int valittuika)
        {
            List<string> Naiset_lapsi = new List<string> { System.IO.File.ReadAllText("lapsi_nais_nimet.txt") };
            List<string> Naiset_nuori = new List<string> { System.IO.File.ReadAllText("nuori_nais_nimet.txt") };
            List<string> Naiset_vanha = new List<string> { System.IO.File.ReadAllText("vanha_nais_nimet.txt") };



            List<string> Miehet_lapsi = new List<string> { System.IO.File.ReadAllText("lapsi_mies_nimet.txt") };
            List<string> Miehet_nuori = new List<string> { System.IO.File.ReadAllText("nuori_mies_nimet.txt") };
            List<string> Miehet_vanha = new List<string> { System.IO.File.ReadAllText("vanha_mies_nimet.txt") };

            if (valittu == "Miehet")
            {
                if (valittuika == 1)
                {
                    GeneratedName = GenerateRandomMiehet(Miehet_lapsi);
                }
                if (valittuika == 2)
                {
                    GeneratedName = GenerateRandomNuoretMiehet(Miehet_nuori);
                }
                if (valittuika == 3)
                {
                    GeneratedName = GenerateRandomVanhatMiehet(Miehet_vanha);
                }


            }
            if (valittu == "Naiset")
            {
                if (valittuika == 1)
                {
                    GeneratedName = GenerateRandomNaiset(Naiset_lapsi);
                }
                if (valittuika == 2)
                {
                    GeneratedName = GenerateRandomNuoretNaiset(Naiset_nuori);
                }
                if (valittuika == 3)
                {
                    GeneratedName = GenerateRandomVanhatNaiset(Naiset_vanha);
                }
            }
        }
        private string GenerateRandomMiehet(List<string> Miehet)
        {
            Random random = new Random();

            string Miehet1 = Miehet[random.Next(Miehet.Count)];

            return $"{Miehet1}";
        }
        private string GenerateRandomNuoretMiehet(List<string> Miehet)
        {
            Random random = new Random();

            string Miehet1 = Miehet[random.Next(Miehet.Count)];

            return $"{Miehet1}";
        }
        private string GenerateRandomVanhatMiehet(List<string> Miehet)
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
        private string GenerateRandomNuoretNaiset(List<string> Naiset)
        {
            Random random = new Random();

            string Naiset1 = Naiset[random.Next(Naiset.Count)];

            return $"{Naiset1}";
        }
        private string GenerateRandomVanhatNaiset(List<string> Naiset)
        {
            Random random = new Random();

            string Naiset1 = Naiset[random.Next(Naiset.Count)];

            return $"{Naiset1}";
        }
    }
}