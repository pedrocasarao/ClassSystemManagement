namespace ClassSystemManagement
{
    class Teacher : Person
    {
        double salary;

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public double getSalary() { return salary; }



        public override string toString()
        {
            return base.toString() + "\n Salary: " + salary;
        }
    }
}
