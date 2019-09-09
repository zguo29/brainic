using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantIterationOne.Web.ViewModels
{
    public class InvasiveViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}
