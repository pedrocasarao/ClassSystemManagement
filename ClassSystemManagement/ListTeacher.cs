using ClassSystemManagement;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassSystemManagement
{
     class ListTeacher
    {
        List<Teacher> allTeacher = new List<Teacher>();

        Teacher teacher = new Teacher();
        public void addNewTeacher(string name, string surname, float phone, string email, double salary ) 
        {
            Teacher newteacher = new Teacher(name,surname,phone, email, salary);
            allTeacher.Add(newteacher); 
            
                
        }

        public bool RemoveTeacher(string name)
        {

            for (int i = 0; i < allTeacher.Count; i++)
            {
                if (allTeacher[i].getName().Equals(name) == true)
                {
                    allTeacher.RemoveAt(i);
                    return true;
                }
                else
                    return false; 
            }

            return false;
        }     
        

     }


}
