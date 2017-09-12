using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YuvamNerede.Web.Models.SiteDropdownModel
{
    public class AnimalSiteVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Color { get; set; }
        public int CategoryID { get; set; }
        public int GenusID { get; set; }
        public HttpPostedFileBase ImagePath { get; set; }
        public string Image { get; set; }
        public IEnumerable<SelectListItem> drpCategories { get; set; }
        public IEnumerable<SelectListItem> drpGenus { get; set; }
    }
}