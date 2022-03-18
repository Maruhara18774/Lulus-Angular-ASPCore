
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lulus.Data.Entities
{
    public class User: IdentityUser<Guid>
    {        
        public virtual List<Order> Orders { get; set; }
        public virtual List<Feedback> Feedbacks { get; set; }
        public virtual List<Address> Addresses { get; set; }
        public virtual List<FavoriteProduct> FavoriteProducts { get; set; }
        public virtual List<FavoriteSubcategory> FavoriteSubcategories { get; set; }
        public virtual List<FavoriteDesigner> FavoriteDesigners { get; set; }
    }
}
