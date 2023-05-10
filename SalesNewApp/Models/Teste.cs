using System.Security.Policy;

namespace SalesNewApp.Models
{
    public class Teste
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Teste () { }

        public Teste (string name, int age)
        {
            Name = name; 
            Age = age;
        }
    }
}
