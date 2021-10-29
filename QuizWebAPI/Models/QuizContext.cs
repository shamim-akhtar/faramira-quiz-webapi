using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizWebAPI.Models;

namespace QuizWebAPI.Models
{
  public class QuizContext : DbContext
  {
    public QuizContext(DbContextOptions<QuizContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Choices> Choices { get; set; }
    public DbSet<Attempts> Attempts { get; set; }
  }
}
