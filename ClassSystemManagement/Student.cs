using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSystemManagement
{
     class Student
    {
        
        public Student(string name , int age, char level ) 
        {
            Name  = name;
            Age = age;
            this.level = level;
        }
        public char level; 
        public string Name 
        { get; set; }
        public int Age 
        { get; set; }
        public Boolean Status 
        { get; set; }

    }
}