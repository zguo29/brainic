using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantIterationOne.Web.Model
{
    public class Native
    {
        public int Id { get; set; }
        [Display(Name ="Common Name")]
        public string Name { get; set; }
        [Display(Name = "Botanical Name")]
        public string BotanicalName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Colour")]
        public string Colour { get; set; }
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Display(Name = "Soil Texture")]
        public string SoilTexture { get; set; }
        public string ImageUrl { get; set; }
    }
}
