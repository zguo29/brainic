using Microsoft.AspNetCore.Http;
using PlantIterationOne.Web.Model;
using PlantIterationOne.Web.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PlantIterationOne.Web.Data
{
    public class DatabaseInitializer
    {
        private readonly INativeService _nativeService;

        public DatabaseInitializer(INativeService nativeService)
        {
            _nativeService = nativeService;
        }

        public static void Seed(PlantContext context)
        {


            /**
            if(!context.Invasives.Any())
            {
                context.Invasives.AddRange
                (new List<Invasive>
                   {
                        new Invasive{ Name = "Anchored Water Hyacinth", ScientificName = "Eichhornia azurea", Habitat="Aquatic", Origin ="Native to Mexico, Central America, South America", Colour="Blue, White, Purple", Spreads="Anchored Water Hyacinth is able to spread when part of the plant breaks away, moves downstream and new daughter plants are produced.", Impacts="Along with other aquatic plants, it floating masses that obstruct navigation .", WeedControl="Anchored Water Hyacinth is not known in Australia, so prevention of its establishment is the best form of control",  ImageUrl = "" },
                        new Invasive{ Name = "Alligator Weed", ScientificName = "Alternanthera philoxeroides", Habitat="Herb, Aquatic", Origin ="South America", Colour="White", Impacts="When growing on land it competes with and displaces native flora species along river and creek banks and in wetlands, and can be harmful to animals. ", Spreads="It spreads in Australia through vegetative reproduction",WeedControl="Prevention is the most cost-effective form of weed control. Quarantine, early detection and good hygiene within infestations will prevent its spread",  ImageUrl = "" },
                        new Invasive{ Name = "African daisy", ScientificName = "Senecio pterophorus", Habitat="Shrub, Herb", Origin ="South Africa", Colour="Yellow", Spreads="Most dispersal is by wind, water, animals and vehicles.", Impacts="African Daisy is an aggressive, pioneer species, which invades sites that have undergone some sort of disturbance such as clearing, soil degradation or fire.", WeedControl="Larger populations can be controlled by cultivation and grazing, slashing, and herbicides",  ImageUrl = "" },
                        }); 
            }
            */
            context.SaveChanges(); 
        }

        public static void Test(PlantContext context)
        {
            context.Natives.Add(new Native
            {
                Name = "pennywort",
                BotanicalName = "Centella asiatica",
                Description = "Used as a culinary vegetable and as a medicinal herb",
                Colour = "Insignificant",
                Type = "Aquatic and Riparian Zone Plants",
                SoilTexture = "Sand,Loam,Clay"
            }); 
            context.SaveChanges(); 
        }
       
    }
}
