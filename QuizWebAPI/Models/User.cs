using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizWebAPI.Models
{
  public class User
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int user_id { get; set; }

    [Required]
    [Column(TypeName = "datetime")]
    public DateTime regtime { get; set; }

    [Required]
    [Column(TypeName = "varchar(45)")]
    public string username { get; set; }

    [Required]
    [Column(TypeName = "varchar(45)")]
    public string useremail { get; set; }
    [Required]

    [Column(TypeName = "varchar(45)")]
    public string userpass { get; set; }
  }
}
