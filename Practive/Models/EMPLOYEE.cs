//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KiemTraCK_Emp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EMPLOYEE
    {
        public int ID { get; set; }
        [Required]
        public string EMPLOYEEID { get; set; }
        [Required]
        public string EMPLOYEENAME { get; set; }
        [Required]
        public string DEPARTMENT { get; set; }
        [Required]
        public int SALARY { get; set; }
    }
}