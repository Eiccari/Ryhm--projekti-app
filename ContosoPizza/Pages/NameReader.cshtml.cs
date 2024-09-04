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

        public void OnGet(string valittu, int valittuika)
        {


            // Generate a random name based on the selected gender
            if (valittu == "Miehet")
            {

                if (valittuika == 1)
                {
                    List<string> Miehet_lapsi = new List<string> { System.IO.File.ReadAllText("nuori_mies_nimet") };
                    GeneroiName = GenerateRandomName(Miehet_lapsi);
                }
                if (valittuika == 2)
                {
                    List<string> Miehet_nuori = new List<string> { System.IO.File.ReadAllText("nuori_mies_nimet") };
                    GeneroiName = GenerateRandomName(Miehet_nuori);
                }
                if (valittuika == 2)
                {
                    List<string> Miehet_vanha = new List<string> { System.IO.File.ReadAllText("vanha_mies_nimet") };
                    GeneroiName = GenerateRandomName(Miehet_vanha);
                }
            }
            else if (valittu == "Naiset")
            {
                List<string> Naiset_lapsi = new List<string> { System.IO.File.ReadAllText("lapsi_nais_nimet") };
                List<string> Naiset_nuori = new List<string> { System.IO.File.ReadAllText("nuori_nais_nimet") };
                List<string> Naiset_vanha = new List<string> { System.IO.File.ReadAllText("vanha_nais_nimet") };
                if (valittuika == 1)
                {
                    GeneroiName = GenerateRandomName(Naiset_lapsi);
                }
                if (valittuika == 2)
                {
                    GeneroiName = GenerateRandomName(Naiset_nuori);
                }
                if (valittuika == 3)
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

