using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ClassSystemManagement
{
    class ClassRoom
    {
        ArrayList elist = new[];

        public void addStuddent(int age, string name)
        {
            elist.Add(new Student(name, age));
        }

        public void removeStuddent(string name)
        {
            for (int i = 0; i <= elist.Count; i++) {
                if (i.Equals(name))
                {
                    elist.RemoveAt(i);
                }
            }
        }

        public void searcStudent(String nameSerch) 
        {
            for (int x= 0; x <= elist.Count ; x++)
            {
                if(x.Equals(nameSerch))
                    
            }
        }


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  

    }
}
