using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.DAL;
public partial class Student
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Student Name")]
    public string Name { get; set; }
}