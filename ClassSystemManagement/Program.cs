using ClassSystemManagement;
using System.Collections;
using System.Reflection.Metadata;

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

        Console.WriteLine("ArrayTEST");
        ListTeacher listTeacher = new ListTeacher();
        listTeacher.addNewTeacher(p1.getName().ToString, p1.getSurname(), p1.getPhone(), p1.getEmail(), p1.getSalary());

        foreach (Teacher teacher in listTeacher) {
            Console.WriteLine(" " + teacher);
            }



        Console.WriteLine("Menu Test");

        
    }

}