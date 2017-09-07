using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuvamNerede.Model.Models.ORM.Entity.SiteEntity
{
    public class Genus : BaseEntity
    {
        public string Name { get; set; }

        public virtual List<Animal> Animal{ get; set; }
        public virtual Category Category { get; set; }


    }
}
