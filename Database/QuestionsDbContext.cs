using System;
using Microsoft.EntityFrameworkCore;

namespace sanoya_sandbox.Database
{
    public class QuestionsDbContext : DbContext
    {
        public QuestionsDbContext()
        {
        }

        public QuestionsDbContext(DbContextOptions<QuestionsDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Question> Questions { get; set; }

    }
}
