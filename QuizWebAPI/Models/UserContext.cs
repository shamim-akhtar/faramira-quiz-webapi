using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizWebAPI.Models
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
    //Table Name StudentDetails
  }
}
