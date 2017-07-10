using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestaurentApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Code Must Be 5 Charecters")]
        public string Code { get; set; }
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(11, MinimumLength = 11, ErrorMessage = "ContactNo Must Be 11 Degit")]
        public int ContactNo { get; set; }
        public string Type { get; set; }
        public string StName { get; set; }
    }
}