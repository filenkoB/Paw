using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;
using Domain.Entities.Abstract;

namespace Domain.Entities
{
    public class PostReaction : Entity
    {
        public bool IsLike { get; set; }
        public string UserId { get; set; }
        public string PostId { get; set; }

        public User User { get; set; }
        public Post Post { get; set; }
    }
}
