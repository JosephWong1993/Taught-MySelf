using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
  /// <summary>
  /// “讲师-课程”联接表
  /// </summary>
  public class CourseAssignment
  {
    public int InstructorID { get; set; }
    public int CourseID { get; set; }
    public Instructor Instructor { get; set; }
    public Course Course { get; set; }
  }
}