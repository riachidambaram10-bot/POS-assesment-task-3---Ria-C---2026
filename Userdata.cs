using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        // File path
        static string filePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
    "users.txt"
);

        // Saves users into the txt file
        public static void SaveUsers()
        {
            List<string> lines = new List<string>();

            foreach (User user in AllUsers)
            {
                lines.Add(user.Username + "," + user.Password);
            }

            File.WriteAllLines(filePath, lines);
        }

        // Loads users from the txt file
        public static void LoadUsers()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    bool userExists = false;

                    foreach (User user in AllUsers)
                    {
                        if (user.Username == parts[0])
                        {
                            userExists = true;
                            break;
                        }
                    }

                    if (!userExists && parts.Length == 2)
                    {
                        User newUser = new User();
                        newUser.Username = parts[0];
                        newUser.Password = parts[1];

                        AllUsers.Add(newUser);
                    }
                }
            }
        }
    }
}



