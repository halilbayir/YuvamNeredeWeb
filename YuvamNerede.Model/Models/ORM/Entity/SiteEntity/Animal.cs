using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace YuvamNerede.Model.Models.ORM.Entity.SiteEntity
{
    public class Animal : BaseEntity
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
        public int GenusId { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("GenusId")]
        public virtual Genus Genus{ get; set; }
        
    }
}
