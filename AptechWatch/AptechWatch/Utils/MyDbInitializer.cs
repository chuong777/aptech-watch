using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using AptechWatch.Entity;

namespace AptechWatch.Utils
{
    public class MyDbInitializer : DropCreateDatabaseIfModelChanges<MVCDbContext>
    {
        private List<Brand> _brands;

        protected override void Seed(MVCDbContext context)
        {
            InitBrand(context);

//            base.Seed(context);
        }

        private void InitBrand(MVCDbContext context)
        {
            _brands = new List<Brand>
            {
                new Brand("Rolex", "thuy si"),
                new Brand("Casio", "nha")
            };
            _brands.ForEach(i => context.Brands.Add(i));
            context.SaveChanges();
        }
    }
}