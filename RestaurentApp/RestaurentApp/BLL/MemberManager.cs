using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurentApp.Models;

namespace RestaurentApp.BLL
{
    public class MemberManager
    {
        public List<Member> GetAll()
        {
            var members = new List<Member>
            {
                new Member() {Id = 1, Name = "General"},
                new Member() {Id = 2, Name = "VIP"},
                new Member() {Id = 3, Name = "Guest"},
             };
            return members;
        }
    }
}