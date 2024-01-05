using ClassSystemManagement;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Net.Http.Headers;
using System.Reflection.Metadata;


 class Program
{
    static void Main(string[] args)
    {
/*
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
        Teacher p3 = new Teacher();
        p3.setName("DAvi");
        p3.setSurname("Marcelo");
        p3.setEmail("marcelo@joao.com");
        p3.setPhone(0830335543);
        p3.toString();

      Console.WriteLine("ArrayTEST");
        ArrayList arrayTeacher = new ArrayList();
        
        
        foreach (Teacher teacher in arrayTeacher)
        {
            Console.WriteLine(" " + teacher.toString());
        }
*/      
        List<Teacher> arrayTeacher = new List<Teacher>();
        List<Student> arrayStudent  = new List<Student>();
        String name = " ";
        Console.WriteLine("Menu Test");

        Console.WriteLine("Choose an option :\n");
        String[] options ={"1-Add new Teacher\n",
                           "2-Remove Teacher\n",
                           "3-List Teachers\n",
                           "4-Add new Student\n",
                           "5-Remove Student\n" +
                           "\n6-List Student \n",
                           "\n7-Exit \n"};

        int option = 0;
        while (true)
        {
            printMenu(options);
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter the number for your choice. " );
                continue;

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error happened. Please try again");
                continue;
            }
            switch (option)
            {

                case 1:
                    //add.teacher#()
                    Teacher teacher = new Teacher();
                    Console.WriteLine("________________Student information______________");
                    Console.WriteLine("Enter student name: ");
                    teacher.setName(Console.ReadLine());
                    Console.WriteLine("Enter the Surname: ");
                    teacher.setSurname(Console.ReadLine());
                    Console.WriteLine("Enter teacher Email:");
                    teacher.setEmail(Console.ReadLine());
                    Console.WriteLine("Enter teacher Phone:");
                    teacher.setPhone(float.Parse(Console.ReadLine()));
                    Console.WriteLine("Enter Teacher Salary :");
                    teacher.setSalary(double.Parse(Console.ReadLine()));

                    arrayTeacher.Add(teacher);
                    break;

                case 2:
                    // remove.teacher
                    
                    Console.WriteLine("-------------Remove Student------------ ");
                    Console.WriteLine("Please type the name of the student:");
                    name = Console.ReadLine();
                    for (int i = 0; i < arrayTeacher.Count; i++)
                    {
                        if (arrayTeacher[i].getName().Equals(name) == true)
                        {
                            arrayTeacher.RemoveAt(i);
                            Console.WriteLine("Student Removed "); break;
                        }
                        else
                            Console.WriteLine("Student Does not Exist");
                    }

                    break;
                case 3:
                    // List.teacher();
                    foreach (Teacher teacher2 in arrayTeacher)
                    {
                        Console.WriteLine(" " + teacher2.toString());
                    }
                    break;

                //-----------------STUDENT-----------
                case 4:
                    //add.student();
                    Student student = new Student();
                    Console.WriteLine("________________Student information______________");
                    Console.WriteLine("Enter The name: ");
                    student.setName(Console.ReadLine());
                    Console.WriteLine("Enter the Surname: ");
                    student.setSurname(Console.ReadLine());
                    Console.WriteLine("Enter Student Email:");
                    student.setEmail(Console.ReadLine());
                    Console.WriteLine("Enter Student Phone:");
                    student.setPhone(float.Parse(Console.ReadLine()));
                    Console.WriteLine("Enter Student LeveL please type A, B or C:");
                    student.setLevel(char.Parse(Console.ReadLine()));
                    arrayStudent.Add(student);

                    Console.WriteLine("Student registred !");
                    break;

                    
                case 5:
                    // remove.student
                    bool status= false;
                    
                    Console.WriteLine("-------------Remove Student------------ ");
                    Console.WriteLine("Please type the name of the student:");
                    name = Console.ReadLine();
                    do
                    {
                        for (int i = 0; i < arrayStudent.Count; i++)
                        {
                            if (arrayStudent[i].getName().Equals(name) == true)
                            {
                                arrayStudent.RemoveAt(i);
                                Console.WriteLine("Student Removed ");
                                status = true;
                                break;
                                
                            }

                            else
                                Console.WriteLine("Student Does not Exist, please try again!");
                        }
                    }while(status != false);

                    break;
                case 6:
                    // List.student();
                    foreach (Student studentPrint in arrayStudent)
                    {
                        Console.WriteLine(" " + studentPrint.toString());
                    }
                    
                    break;
                case 7:
                    //Exit
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter an integer value between 1 and 7  " + options.Length);
                    break;
            }


        }
    }
    
    public static void printMenu(String[] options) 
    {

        foreach (String option in options)
        {
            Console.WriteLine(option);
        }
        Console.WriteLine("Please select your  Option: ");
    }
}