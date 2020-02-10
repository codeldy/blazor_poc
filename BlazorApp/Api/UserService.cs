using System;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp.Models;

namespace BlazorApp.Api
{
    public class UserService
    {
        public async Task<User[]> GetUsersAsync()
        {
            
            return new User[] { new User() { Username = "test", Password = "test1234"} };
        }

        /*
            // working:
            public async Task<User[]> GetUsersAsync() => new User[] { new User() { Username = "test", Password = "test1234"} };
         */
    }
}
