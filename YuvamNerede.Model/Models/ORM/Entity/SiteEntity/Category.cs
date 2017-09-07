using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace YuvamNerede.Model.Models.ORM.Entity.SiteEntity
{
    public class Category:BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual List<Genus> Genus { get; set; }
        public virtual List<Animal> Animal { get; set; }

    }
}
