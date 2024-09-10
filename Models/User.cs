using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users")]
public class User
{
    [Key]
    [Column("idUsers")] // Правильное имя столбца
    public int IdUsers { get; set; }

    [Column("UserName")] // Правильное имя столбца
    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string UserName { get; set; }

    [Column("Password")] // Правильное имя столбца
    [Required]
    public string Password { get; set; }

    [Column("Gender")] // Правильное имя столбца
    [Required]
    public string Gender { get; set; }
}
