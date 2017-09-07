using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuvamNerede.Model.Models.ORM.Entity.SiteEntity
{
    public class SiteMenu : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string CssClass { get; set; } 
    }
}
