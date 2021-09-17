using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Post : Entity
    {
        public string AttachmentId { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastEditedDate { get; set; }
        public string UserId { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<PostReaction> PostReactions { get; set; }
        public User User { get; set; }
    }
}
