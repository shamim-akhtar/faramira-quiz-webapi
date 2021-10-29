using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizWebAPI.Models
{
  public class Choices
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]
    [Column(TypeName = "int")]
    public int question_id { get; set; }

    [Required]
    [Column(TypeName = "bit(1)")]
    public bool is_right_choice { get; set; }

    [Required]
    [Column(TypeName = "varchar(64)")]
    public string choice { get; set; }
  }
}
