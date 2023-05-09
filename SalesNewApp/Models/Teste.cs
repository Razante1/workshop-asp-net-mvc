namespace SalesNewApp.Models
{
    public class Teste
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Teste() { }

        public Teste(string name, string email, int age)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }

}
