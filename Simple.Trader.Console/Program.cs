
using SimpleTrade.Domain.Models;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;
using System.Linq;

namespace Simple.Trader.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GenericDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContexfactory());
             userService.Create(new User { Username = "Emilio 55555"}).Wait();
            // System.Console.WriteLine("Data inserted.!!");
            // var userUpdate = userService.Update(1, new User { Username = "Emilio Barrera 5" }).Result;
            //bool deleteUser = userService.Delete(3).Result;
            System.Collections.Generic.IEnumerable<User> allusers = userService.GetAll().Result;
            //System.Console.WriteLine("User Deleted.!!!!");
            if (!allusers.Any())
            {
                System.Console.WriteLine("There aren't users a databaase");

            }
            else
            {

                foreach (var users in allusers)
                {

                    System.Console.WriteLine($"The Users: {users.Username}");
                 
                }
            }
        }
    }
}
