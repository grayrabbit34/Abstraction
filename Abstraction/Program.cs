using Abstraction;

class Program
{
    public static void Main()
    {
        ProjectManager projectManager = new ProjectManager();

        projectManager.Name = "Hasan";
        projectManager.Surname = "Çıldırmış";

        projectManager.Gorev();

    }
}