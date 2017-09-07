using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuvamNerede.Model.Models.ViewModels
{
    public class SiteMenuVM : BaseVM
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string cssClass { get; set; }
    }
}
