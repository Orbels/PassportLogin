﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportLogin.AuthService
{
    public class UserAccount
    {
        [Key, Required]
        public Guid UserId { get; set; }
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public List<PassportDevice> PassportDevices = new List<PassportDevice>();

    }
}
