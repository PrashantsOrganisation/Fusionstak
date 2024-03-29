﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FusionStackBackEnd.Models
{
    public class User
    {
        [Key]
        private int id { set; get; }

        [Required]
        private string name { set; get; }

        [Required]

        private string email { set; get; }

        [Required]

        private string password { set; get; }

        private string phone { set; get; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Phone { set; get; }
    }
}
