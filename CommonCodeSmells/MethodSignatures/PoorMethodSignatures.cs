﻿using System;
using System.Linq;

namespace CommonCodeSmells.MethodSignatures
{
    public class PoorMethodSignatures
    {
        public void Run()
        {
            var userService = new UserService1();

            var user = userService.GetUser("username", "password", true);
            var anotherUser = userService.GetUser("username", null, false);
        }
    }

    public class UserService1
    {
        private UserDbContext1 _dbContext = new UserDbContext1();

        public User1 GetUser(string username, string password, bool login)
        {
            if (login)
            {
                // Check if there is a user with the given username and password in db
                // If yes, set the last login date 
                // and then return the user. 
                var user = _dbContext.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
                if (user != null)
                    user.LastLogin = DateTime.Now;
                return user;
            }
            else
            {
                // Check if there is a user with the given username
                // If yes, return it, otherwise return null
                var user = _dbContext.Users.SingleOrDefault(u => u.Username == username);
                return user;
            }
        }
    }

    public class UserDbContext1 : DbContext
    {
        public IQueryable<User1> Users { get; set; }
    }

    public class DbSet1<T>
    {
    }

    public class DbContext1
    {
    }

    public class User1
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
