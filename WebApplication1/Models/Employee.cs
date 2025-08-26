using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace WebApplication1.Models
{
    public class Employee
    {
        //[Required(ErrorMessage = "This is a Required Field")]
        //[Range(1, 100)]
        public int Id { get; set; }
        [Required(ErrorMessage = "This is a Required Field")]
        [myValidation]
        public string Name { get; set; }
        [Required(ErrorMessage = "This is a Required Field")]
        public string Address { get; set; }
        public List<tblemployeemst> Employees { get; set; }
    }
}