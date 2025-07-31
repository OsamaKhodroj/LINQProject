using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserService();
            userService.AddFakeUser(); 
        }
    }

    public class UserData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}