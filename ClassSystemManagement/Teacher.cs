namespace ClassSystemManagement
{
    class Teacher : Person
    {
        double salary;
        public Teacher(string name , string surname , float phone ,string email, double salary) 
        {
            this.setName(name);
            this.setSurname(surname);
            this.setPhone(phone); 
            this.setSalary(salary);
            this.setEmail(email);
            
        }

        public Teacher() 
        {
        }

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
