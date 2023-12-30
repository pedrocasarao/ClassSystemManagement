namespace ClassSystemManagement
{
    class Person
    {

        string name;
        string surname;
        float phone;
        string email;
        public Person(string name, string surname, float phone, string email)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.email = email;

        }
        public Person()
        { }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }
        public void setPhone(float phone)
        {
            this.phone = phone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public String getName()
        {
            return name;
        }
        public String getSurname()
        {
            return surname;
        }
        public float getPhone()
        {
            return phone;
        }
        public string getEmail()
        {
            return email;
        }

        public virtual string toString()
        {
            return "name:" + name + "\n Surname: " + surname + "\n Phone: " + phone + "\n Email: " + email;
        }
    }

}
