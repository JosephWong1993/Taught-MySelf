﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
  /// <summary>
  /// 办公室
  /// </summary>
  public class OfficeAssignment
  {
    [Key]
    public int InstructorID { get; set; }
    [StringLength(50)]
    [Display(Name = "Office Location")]
    public string Location { get; set; }

    public Instructor Instructor { get; set; }
  }
}