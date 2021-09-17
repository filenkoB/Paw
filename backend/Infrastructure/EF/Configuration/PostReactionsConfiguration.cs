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
    public class PostReactionsConfiguration : IEntityTypeConfiguration<PostReaction>
    {
        public void Configure(EntityTypeBuilder<PostReaction> builder)
        {
            builder.HasOne(pr => pr.Post)
                .WithMany(p => p.PostReactions)
                .HasConstraintName("post_reaction__post_FK")
                .HasForeignKey(pr => pr.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pr => pr.User)
                .WithMany(u => u.PostReactions)
                .HasConstraintName("post_reaction__user_FK")
                .HasForeignKey(pr => pr.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}