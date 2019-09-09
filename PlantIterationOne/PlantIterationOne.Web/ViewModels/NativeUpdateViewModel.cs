using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantIterationOne.Web.ViewModels
{
    public class NativeUpdateViewModel
    {
        [Display(Name = "植物名称")]
        [Required(ErrorMessage = "{0}是必填项"), MaxLength(100, ErrorMessage = "{0}的长度不可超过{1}")]
        public string Name { get; set; }


        [Display(Name = "图片")]
        public string ImageUrl { get; set; }
    }
}
