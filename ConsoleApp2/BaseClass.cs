using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public abstract class NodeModel<T>
    {
        public string Name { get; set; }
        public string Description { get; set; } // details on hover - tooltip
        public abstract List<T>? Nodes { get; set; }
        public NodeModel() 
        { 
            
        }

    }

    public class Node2023
    {
        public string Name { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Node2023>? SubNodes { get; set; }
        public List<Node2023>? Employees { get; set; }
        public Node2023() { }
    }

    public class OrgChart2023 : NodeModel<KeyValuePair<string, Dictionary<string, Node2023>>>
    {
        public override List<KeyValuePair<string, Dictionary<string, Node2023>>>? Nodes 
        { 
            get; 
            set; 
        }
    }
}
