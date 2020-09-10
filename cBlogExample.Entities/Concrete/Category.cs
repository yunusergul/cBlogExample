using cBlogExample.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace cBlogExample.Entities.Concrete
{
    public class Category:EntitiyBase,IEntitity
    {
        //public override string CreatedByName { get; set; } = "Admin";
        public string Name { get; set; }
        public string Description { get; set; }
        //article = post olarak adlandırılabilir
        public ICollection<Article> Articles { get; set; }
    }
}
