namespace ClassSystemManagement
{
    class Student : Person
    {
        Char level;
        public Student()
        {

        }
        public Student(char level)
        {
            this.level = level;
        }

        public override string toString()
        {
            return base.toString() + "\n Level " + level;
        }
    }

}
