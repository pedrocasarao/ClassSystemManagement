namespace ClassSystemManagement
{
    class Student : Person
    {
        char level;
        public Student()
        {

        }
        public Student(char level)
        {
            this.level = level;
        }
        public void setLevel(char level) 
        {
           this.level=level;
                    
        }

        public char getLevel(char level) 
        { 
            return (char)level;
        }

        public override string toString()
        {
            return base.toString() + "\n Level " + level;
        }
    }

}
