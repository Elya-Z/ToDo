using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("users")]
public class User
{
    [Key]
    [Column("idUsers")] // ���������� ��� �������
    public int IdUsers { get; set; }

    [Column("UserName")] // ���������� ��� �������
    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string UserName { get; set; }

    [Column("Password")] // ���������� ��� �������
    [Required]
    public string Password { get; set; }

    [Column("Gender")] // ���������� ��� �������
    [Required]
    public string Gender { get; set; }
}
