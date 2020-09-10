using cBlogExample.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace cBlogExample.Entities.Concrete
{
    public class Role:EntitiyBase,IEntitity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
