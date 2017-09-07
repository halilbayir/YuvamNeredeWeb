using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuvamNerede.Model.Models.ViewModels
{
    public class GenusVM : BaseVM
    {
        public string Name { get; set; }
        public string CategoryName { get; set; }
    }
}
