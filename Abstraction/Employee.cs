using System;
namespace Abstraction
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Department { get; set; }
       
        public abstract void Gorev();
    }

    public class ProjectManager : Employee
    { 

        public override void Gorev()
        {
            Console.WriteLine($"Ben {Name} {Surname}, proje yöneticisi olarak çalışıyorum.");
        }
    }
}

