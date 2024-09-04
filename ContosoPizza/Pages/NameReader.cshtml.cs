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
            List<string> Naiset = new List<string> { "Mari", "Siiri", "Emma", "Emilia", "Jaana", "Katja" };
            List<string> Miehet = new List<string> { "Mikko", "Jari", "Ville", "Jorma", "Joonas", "Leo" };

            // Generate a random name based on the selected gender
            if (valittu == "Miehet")
            {
                GeneroiName = GenerateRandomName(Miehet);
            }
            else if (valittu == "Naiset")
            {
                GeneroiName = GenerateRandomName(Naiset);
            }
        }

        private string GenerateRandomName(List<string> names)
        {
            Random random = new Random();
            return names[random.Next(names.Count)];
        }
    }
}

