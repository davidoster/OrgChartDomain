using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var CEO = new MainObject()
            {
                Name = "BN",
            };

            var groupFinance = new MainObject()
            {
                Name = "Group Finance",
                Levels = new List<BaseClass>()
                {
                    new MainObject()
                    {
                        Name = "Dept1"
                    },
                    new MainObject()
                    {
                        Name = "Dept2"
                    },
                    new MainObject()
                    {
                        Name = "Dept3"
                    },
                    new MainObject()
                    {
                        Name = "Dept4"
                    },
                }
                
            }
        }
    }
}