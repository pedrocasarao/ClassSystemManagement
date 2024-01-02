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

        Teacher p2 = new Teacher();
        p2.setName("Bruno");
        p2.setSurname("Marcelo");
        p2.setEmail("marcelo@joao.com");
        p2.setPhone(0830335543);
        p2.toString();
        Teacher p3= new Teacher();
        p3.setName("DAvi");
        p3.setSurname("Marcelo");
        p3.setEmail("marcelo@joao.com");
        p3.setPhone(0830335543);
        p3.toString();

        Console.WriteLine("ArrayTEST");
        ArrayList arrayTeacher = new ArrayList();
        arrayTeacher.Add(p1);
        arrayTeacher.Add(p2);
        arrayTeacher.Add(p3);

        foreach (Teacher teacher in arrayTeacher)
        {
            Console.WriteLine(" " + teacher.toString());
        }



        Console.WriteLine("Menu Test");

        Console.WriteLine("Choose an option :");
        String[] options ={"1-Add new Teacher\n",
                          "2-Remove Teacher,\n" +
                          "3-List Teachers \n"};

        int option = 0;
        while (true) 
        {
            printMenu(options);
            try {
                option = Convert.ToInt32(Console.ReadLine());
            };
        }
    }
    public static void printMenu(String[] options) 
    {

        foreach (String option in options)
        {
            Console.WriteLine(options);
        }
        Console.WriteLine("Chose your Option");
    }
}