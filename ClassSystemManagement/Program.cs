using ClassSystemManagement;

internal class Program
{
         static void Main(string[] args)
    {
        Teacher p1 = new Teacher();
        p1.setName("Joao");
        p1.setSurname("Marcelo");
        p1.setEmail("marcelo@joao.com");
        p1.setPhone(0830335543);
        p1.toString();
        p1.setSalary(2000);
        Console.WriteLine(p1.toString());
    }

}