namespace OOP_PropertyDemo
{
    class OldStudent
    {
        string username="a@a";
        string password;
        string name;
        string surname;
        int age;

        //public string GetPassword()
        //{
        //    return "*************";
        //}
        public void SetPassword(string value)
        {
            password = value;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }

        public string GetSurName()
        {
            return surname;
        }
        public void SetSurName(string value)
        {
            surname = value;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int value) => age = value;


        public string GetFullName()=> name + " " + surname;
        
           
        
    }
}
