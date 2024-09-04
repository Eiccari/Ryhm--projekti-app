using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

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
        public string valittuika = "";
        public void Ika(int ika)
        {
            Console.WriteLine("Minkä ikäinen, alle 101");
            while (true)
            {
                ika = Convert.ToInt32(Console.ReadLine());
                if (ika >= 1)
                {
                    if (ika <= 20)
                    {
                        valittuika = "Lapsi";
                        break;
                    }
                    else if (ika <= 50 && ika > 20)
                    {
                        valittuika = "Aikuinen";
                        break;
                    }
                    else if (ika <= 100 && ika > 50)
                    {
                        valittuika = "vanhus";
                        break;
                    }
                    else if (ika > 101)
                    { Console.WriteLine("kuollut"); }
                }
                else if (ika < 1)
                { Console.WriteLine("Ei ole syntynyt"); }
            }
        }



        public void OnGet(string valittu)
        {
            List<string> Naiset = new List<string> { "Mari", "Siiri", "Emma", "Emilia", "Jaana", "Katja" };
            List<string> Miehet = new List<string> { "Mikko", "Jari", "Ville", "Jorma", "Joonas", "Leo" };
            if (valittu == "Miehet")
            {
                //GeneratedName = GenerateRandomNaiset(Naiset);
                if (valittuika == "Lapsi")
                {
                    //GeneratedName = GenerateRandomMiehet(Miehet);
                    Console.WriteLine("lapsi");
                }
                if (valittuika == "Aikuinen")
                {
                    //GeneratedName = GenerateRandomMiehet(Miehet);
                    Console.WriteLine("aikuinen");
                }
                if (valittuika == "vanhus")
                {
                    //GeneratedName = GenerateRandomMiehet(Miehet);
                    Console.WriteLine("vanhus");
                }
                GeneratedName = GenerateRandomMiehet(Miehet);
            }
            if (valittu == "Naiset")
            {
                //GeneratedName = GenerateRandomNaiset(Naiset);
                if (valittuika == "Lapsi")
                {
                    //GeneratedName = GenerateRandomMiehet(Miehet);
                    Console.WriteLine("lapsi");
                }
                if (valittuika == "Aikuinen")
                {
                    //GeneratedName = GenerateRandomMiehet(Miehet);
                    Console.WriteLine("aikuinen");
                }
                if (valittuika == "vanhus")
                {
                    //GeneratedName = GenerateRandomMiehet(Miehet);
                    Console.WriteLine("vanhus");
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