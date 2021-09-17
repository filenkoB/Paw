using System;
using System.Collections.Generic;
using Domain.Entities.Abstract;
using System.Text;

namespace Domain.Entities
{
    public class User : Human
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegisteredAt { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<PostReaction> PostReactions { get; set; }
        public ICollection<CommentReaction> CommentReactions { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
