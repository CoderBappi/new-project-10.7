using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurentApp.Models;

namespace RestaurentApp.BLL
{
    public class StudentManager
    {
        public List<Member> GetAll()
        {
            var students = new List<Member>
            {
                new Member() {Id = 1, Name = "Jhon"},
                new Member() {Id = 2, Name = "Raj"},
                new Member() {Id = 3, Name = "Ghost"},
             };
            return students;
        }
    }
}