using System.ComponentModel.DataAnnotations;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orgChartPC = new OrgChart2023()
            {
                Name = "PeopleCert Group",
                Nodes = // each node represents the chart of choice
                new List<KeyValuePair<string, Dictionary<string, Node2023>>>
                {
                    new KeyValuePair<string, Dictionary<string, Node2023>>(
                        "PeopleCert Global",
                        new Dictionary<string, Node2023>()
                        {
                            {
                                "CEO",
                                new Node2023() 
                                { 
                                   Name =  "CEO",
                                   SubNodes = { },
                                   Employees = { },
                                }
                            }
                        })
                }
            };
        }
    }
}