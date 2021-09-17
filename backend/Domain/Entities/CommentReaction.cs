using System;
using System.Collections.Generic;
using Domain.Entities.Abstract;
using System.Text;

namespace Domain.Entities
{
    public class CommentReaction : Entity
    {
        public bool IsLike { get; set; }
        public string UserId { get; set; }
        public string CommentId { get; set; }

        public User User { get; set; }
        public Comment Comment { get; set; }
    }
}
