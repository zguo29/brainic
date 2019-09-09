using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantIterationOne.Web.Model
{
    public class Invasive
    {
        public int Id { get; set; }
        [Display(Name="Common Name")]
        public string Name { get; set; }
        [Display(Name = "Scientific Name")]
        public string ScientificName { get; set; }
        [Display(Name = "Habitat")]
        public string Habitat { get; set; }
        [Display(Name = "Origin")]
        public string Origin { get; set; }
        [Display(Name = "Colour")]
        public string Colour { get; set; }
        [Display(Name = "Spreads")]
        public string Spreads { get; set; }
        [Display(Name = "impacts")]
        public string Impacts { get; set; }
        [Display(Name = "Weed Control")]
        public string WeedControl { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}
