using cBlogExample.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace cBlogExample.Entities.Concrete
{
    public class Article:EntitiyBase,IEntitity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int CommentCount { get; set; }
        public string SeoAlter { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTag { get; set; }
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
