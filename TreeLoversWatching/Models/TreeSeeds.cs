using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeLoversWatching.Data;

namespace TreeLoversWatching.Models
{
    public static class TreeSeeds
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Trees.Any())
                {
                    return;
                }

                context.Trees.AddRange(
                    new Trees
                    {
                        TreeName = "Polylepis Tarapacana",
                        Latin = "Polylepis tomentella",
                        TreeType = "Medium-sized evergreen tree",
                        Location = "Central Andes, Altiplano",
                        Category = "High Altitude Trees",
                        //GeoLocation = new Point(16.3738, 48.2082)
                        //{
                        //    SRID = 4326
                        //}

                    },

                    new Trees
                    {
                        TreeName = "Huon Pine",
                        Latin = "Lagarostrobos franklinii",
                        TreeType = "Conifer, Colony forming",
                        Location = "West coast of Tasmania, Australia",
                        Category = "Oldest Trees",
                        GeoLocation = new Point(-43.0953431, 146.637289)
                        {
                            SRID = 4326
                        }
                        
                    },

                    new Trees
                    {
                        TreeName = "King Clone",
                        Latin = "Larrea tridentata",
                        TreeType = "Creosote Bush, colony forming",
                        Location = "Central Mojave Desert, north of CA route 247",
                        Category = "Oldest Trees"

                    },

                    new Trees
                     {
                         TreeName = "Judean date palm",
                         Latin = "Phoenix dactylifera",
                         TreeType = "date palm",
                         Location = "Ketura, Isreal",
                         Category = "Previously extinct"

                    }
                    );
                context.SaveChanges();
            }
        }
    }
}

