using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var domains = new List<string>
        {
            "google.com", "yahoo.com", "vk.com", "facebook.com",
            "instagram.com", "twitter.com", "youtube.com",
            "linkedin.com", "tiktok.com", "reddit.com"
        };

        var result = domains.FirstOrDefault(d => d == "vk.com");
        Console.WriteLine(result != null ? $"Сайт знайдено: {result}" : "Сайт не знайдено");
    }
}
