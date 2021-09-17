using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class Comment : Entity
    {
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime LastEditedDate { get; set; }
        public string UserId { get; set; }
        public string PostId { get; set; }
        public string ParentCommentId { get; set; }

        public User User { get; set; }
        public Post Post { get; set; }
        public Comment ParentComment { get; set; }
        public ICollection<CommentReaction> CommentReactions { get; set; }
        public ICollection<Comment> ChildComments { get; set; }
    }
}
