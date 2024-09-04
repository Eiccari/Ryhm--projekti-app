using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
            List<string> Naiset = new List<string> { "Mari", "Siiri", "Emma", "Emilia", "Jaana", "Katja" };
            List<string> Miehet = new List<string> { "Mikko", "Jari", "Ville", "Jorma", "Joonas", "Leo" };
            if (valittu == "Miehet")
            {
                if (valittuika == "Lapset")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet);
                }
                if (valittuika == "Nuoret")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet);
                }
                if (valittuika == "Aikuiset")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet);
                }

                GeneratedName = GenerateRandomMiehet(Miehet);
            }
            if (valittu == "Naiset")
            {
                GeneratedName = GenerateRandomNaiset(Naiset);
                if (valittuika == "Lapset")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet);
                }
                if (valittuika == "Nuoret")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet);
                }
                if (valittuika == "Aikuiset")
                {
                    GeneratedName = GenerateRandomMiehet(Miehet);
                }
            }
            GeneratedName = GenerateRandomNaiset(Naiset);
            GeneratedName = GenerateRandomMiehet(Miehet);
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