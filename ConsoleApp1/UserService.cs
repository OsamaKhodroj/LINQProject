using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UserService
    {
        private List<User> _users;

        public UserService()
        {
            if (_users == null)
            {
                _users = new List<User>();
            }
        }

        public void AddFakeUser()
        {
            _users.Add(new User() { Id = 1, Name = "John1 Doe", Address = "123 Main St", PhoneNumber = "11" });
            _users.Add(new User() { Id = 2, Name = "John2 Doe", Address = "123 Main St", PhoneNumber = "22" });
            _users.Add(new User() { Id = 3, Name = "John3 Doe", Address = "123 Main St", PhoneNumber = "33" });
            _users.Add(new User() { Id = 4, Name = "John4 Doe", Address = "123 Main St", PhoneNumber = "44" });
            _users.Add(new User() { Id = 5, Name = "John5 Doe", Address = "123 Main St", PhoneNumber = "55" });
            _users.Add(new User() { Id = 6, Name = "John6 Doe", Address = "123 Main St", PhoneNumber = "66" });
            _users.Add(new User() { Id = 7, Name = "John7 Doe", Address = "123 Main St", PhoneNumber = "77" });
            _users.Add(new User() { Id = 8, Name = "John8 Doe", Address = "123 Main St", PhoneNumber = "88" });
        }

        public List<User> GetUsers()
        {
            return _users;
        }
    }
}
