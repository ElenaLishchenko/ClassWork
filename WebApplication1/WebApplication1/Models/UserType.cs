using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<User> Users {get; set;}

        public UserType()
        {
            Users = new List<User>();
        }
    }
}