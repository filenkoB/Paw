using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EF.Configuration
{
    public class CommentReactionsConfiguration : IEntityTypeConfiguration<CommentReaction>
    {
        public void Configure(EntityTypeBuilder<CommentReaction> builder)
        {
            builder.HasOne(cr => cr.Comment)
                .WithMany(c => c.CommentReactions)
                .HasConstraintName("comment_reaction__comment_FK")
                .HasForeignKey(cr => cr.CommentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(cr => cr.User)
                .WithMany(u => u.CommentReactions)
                .HasConstraintName("comment_reaction__user_FK")
                .HasForeignKey(cr => cr.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
