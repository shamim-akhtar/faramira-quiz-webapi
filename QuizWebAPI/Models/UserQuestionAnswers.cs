using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizWebAPI.Models
{
  public class UserQuestionAnswers
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime answer_time { get; set; }

    [Required]
    [Column(TypeName = "bit(1)")]
    public bool is_right { get; set; }

    [Required]
    [Column(TypeName = "int")]
    public int choice_id { get; set; }

    [Required]
    [Column(TypeName = "int")]
    public int question_id { get; set; }

    [Required]
    [Column(TypeName = "int")]
    public int user_id { get; set; }
  }
}
