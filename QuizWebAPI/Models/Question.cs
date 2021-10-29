using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizWebAPI.Models
{
  public class Question
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]
    [Column(TypeName = "varchar(1000)")]
    public string question { get; set; }

    [Required]
    [Column(TypeName = "bit(1)")]
    public bool is_active { get; set; }
  }
}
