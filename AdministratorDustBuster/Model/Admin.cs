using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorDustBuster.DTO
{
    internal class Admin
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public int Sex { get; set; }
        public string DateBirth { get; set; }
        public string Image { get; set; }
        public string permanent_address { get; set; }
        public string temporary_residence_address { get; set; }
        public string position { get; set; }
        public string JoiningDate { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }
    }
}
