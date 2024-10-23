using System.ComponentModel;
using BLL.DAL;

namespace BLL.Model;

public class StudentModel
{
    public Student Record { get; set; }

    [DisplayName("Student Name")]
    public string Name => Record.Name;
}