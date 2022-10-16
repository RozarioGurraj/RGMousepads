using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RGMousepads.Data;
using System;
using System.Linq;

namespace RGMousepads.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RGMousepadsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RGMousepadsContext>>()))
            {
                // Look for any Entries In Database.
                if (context.MousepadsClass.Any())
                {
                    return;   // DB has been seeded
                }

                context.MousepadsClass.AddRange(

                    new MousepadsClass
                    {
                        Name="Death Header",
                        Brand="Razor",
                        Size="35x35",
                        color="Black",
                        shape="Round",
                        ModelNumber=565,
                        Review=4.5 
                    },
                    
                    new MousepadsClass
                    {
                        Name="Death Header 1.1",
                        Brand="Razor",
                        Size="36x36",
                        color="Black",
                        shape="Rectangle",
                        ModelNumber=644,
                        Review=3 
                    },

                    new MousepadsClass
                    {
                        Name="RGB Pad",
                        Brand="Razor",
                        Size="56x84",
                        color="RGB Lights",
                        shape="Long Rectangle",
                        ModelNumber=855,
                        Review=4.5 
                    },

                    new MousepadsClass
                    {
                        Name = "single Color RGB",
                        Brand = "logi",
                        Size = "102x50",
                        color = "Silver",
                        shape = "Cirlce",
                        ModelNumber =896,
                        Review =2.5
                    },

                    new MousepadsClass
                    {
                        Name = "Mousepade",
                        Brand = "logi",
                        Size = "64x64",
                        color = "Black",
                        shape = "Rectangle",
                        ModelNumber =741,
                        Review =5
                    },

                    new MousepadsClass
                    {
                        Name = "Gaming Pad",
                        Brand = "HP",
                        Size = "74x74",
                        color = "Red",
                        shape = "Semi-Round",
                        ModelNumber =752,
                        Review =4.5
                    },

                    new MousepadsClass
                    {
                        Name = "Gaming Pad v2",
                        Brand = "HP",
                        Size = "84x84",
                        color = "Black",
                        shape = "Square",
                        ModelNumber =844,
                        Review =3.5
                    },

                    new MousepadsClass
                    {
                        Name = "GamePad v3",
                        Brand = "Dell",
                        Size = "62x45",
                        color = "Black",
                        shape = "Round",
                        ModelNumber =963,
                        Review =2
                    },

                    new MousepadsClass
                    {
                        Name = "Mousepade v3",
                        Brand = "logi",
                        Size = "87x62",
                        color = "Black",
                        shape = "Round",
                        ModelNumber =4125,
                        Review =3.5
                    },

                    new MousepadsClass
                    {
                        Name = "Mousepad v4",
                        Brand = "logi",
                        Size = "47x25",
                        color = "Black",
                        shape = "Rectangle",
                        ModelNumber =4563,
                        Review =3
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
