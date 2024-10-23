// BLL/Services/StudentService.cs
using System.Collections.Generic;
using Assignment5_AyseOzgeErkan.Models;
using BLL.DAL;
using BLL.Services;
using BLL.Services.Bases;
using Microsoft.Extensions.DependencyInjection; // Assuming Student model exists in this namespace

public interface IStudentService
{
    IEnumerable<Student> Query();  // Fetch all students

    Service Create(Service student);  // Add a new student

    Service Update(Student student);  // Update an existing student

    void Delete(int studentId);  // Delete a student by ID
}

public class StudentService : Service, IStudentService
{
    private readonly List<Student> _students = new List<Student>();

    // Implementing the Query method from IStudentService
    public IEnumerable<Student> Query()
    {
        Log("Query method called");  // Using Log method from base Service class
        return _students;
    }

    // Implementing the Create method from IStudentService
    public Service Create(Service student)
    {
        student.Id = _students.Count + 1;  // Example ID assignment logic
        _students.Add(student);
        return student;
    }

    // Implementing the Update method from IStudentService
    public Service Update(Student student)
    {
        var existingStudent = _students.Find(s => s.Id == student.Id);
        if (existingStudent != null)
        {
            existingStudent.Name = student.Name; // Update fields accordingly
            // Update other fields if needed
        }
        return existingStudent;
    }

    // Implementing the Delete method from IStudentService
    public void Delete(int studentId)
    {
        var student = _students.Find(s => s.Id == studentId);
        if (student != null)
        {
            _students.Remove(student);
        }
    }
}