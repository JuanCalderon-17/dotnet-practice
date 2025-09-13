namespace dotnetpractice;

 public class Person
    {
        public string name = string.Empty;
        public string surname = string.Empty;

        public void Greet()
        {
            Console.WriteLine("My name is " + name + " " + surname);
        }
    }