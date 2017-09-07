using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YuvamNerede.Model.Models.ORM.DBContext;
using YuvamNerede.Model.Models.ORM.Entity.SiteEntity;

namespace YuvamNerede.Service.Repos
{
    public class AnimalRepo
    {
        public static int AnimalGenus(string name)
        {
            using (YuvamNeredeDBContext db=new YuvamNeredeDBContext())
            {
                var result = db.Genus.FirstOrDefault(x => x.Name == name);
                if (result != null)
                {
                    return result.ID;
                }
                else
                {

                    Genus genus = new Genus();
                    genus.Name = name;
                    db.Genus.Add(genus);
                    db.SaveChanges();
                    return genus.ID;
                }
            }
          
        }

        public static int AnimalCategory(string name)
        {
            using (YuvamNeredeDBContext db = new YuvamNeredeDBContext())
            {
                var result = db.Category.FirstOrDefault(x => x.Name == name);
                if (result != null)
                {
                    return result.ID;
                }
                else
                {

                    Category cat = new Category();
                    cat.Name = name;
                    db.Category.Add(cat);
                    db.SaveChanges();
                    return cat.ID;
                }
            }
        }

        public static string AnimalGenusName(int id)
        {
            using (YuvamNeredeDBContext db=new YuvamNeredeDBContext())
            {
               var result = db.Genus.FirstOrDefault(x => x.ID == id).Name;
                return result;
               
            }
        }
        public static string AnimalCategoryName(int id)
        {
            using (YuvamNeredeDBContext db = new YuvamNeredeDBContext())
            {
                var result = db.Category.FirstOrDefault(x => x.ID == id).Name;
                return result;

            }
        }
    }
}
