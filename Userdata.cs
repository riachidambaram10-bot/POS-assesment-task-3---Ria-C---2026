using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_assesment_task_3___Ria_C___2026
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    // This class is STATIC so it's accessible from any form
    public static class UserData
    {
        // This list holds all the users who sign up
        public static List<User> AllUsers = new List<User>()
        { 
            // Keeping one admin account so I can always log in
            new User { Username = "admin@trendfitz.com.au", Password = "password123" }
        };
    }
}

