using System;
using System.ComponentModel.DataAnnotations;
 
namespace backend.Models
{
 public class TestValue
 {
 [Key]
 public int TestValueId { get; set; }
 public double TestValueValue { get; set; }
 public string TestValueDate { get; set; }
 }
}