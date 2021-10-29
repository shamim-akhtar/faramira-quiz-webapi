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
    public DbSet<QuizWebAPI.Models.QuestionChoices> QuestionChoices { get; set; }
    public DbSet<QuizWebAPI.Models.UserQuestionAnswers> UserQuestionAnswers { get; set; }
  }
}
