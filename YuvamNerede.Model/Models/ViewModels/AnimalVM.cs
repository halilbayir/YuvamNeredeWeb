using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace YuvamNerede.Model.Models.ViewModels
{
    public class AnimalVM:BaseVM
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string CategoryName { get; set; }
        public string GenusName { get; set; }
        public string Color { get; set; }
        public int CategoryID { get; set; }
        public int GenusID { get; set; }
        public HttpPostedFileBase ImagePath { get; set; }
        public string Img { get; set; }

    }
}
