using System.Collections.Generic;
using System.Linq;
using Auth.Models;

namespace Auth.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User {Id = 1, Username = "batman", Password = "secret", Role = "manager"});
            users.Add(new User {Id = 1, Username = "robin", Password = "secret", Role = "employee"});
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}