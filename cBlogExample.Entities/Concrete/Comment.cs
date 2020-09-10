using cBlogExample.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace cBlogExample.Entities.Concrete
{
    public class Comment:EntitiyBase,IEntitity
    {
        public String Text { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
