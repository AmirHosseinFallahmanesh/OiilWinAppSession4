namespace OOP_Constructor
{
    class Student
    {
        string username = "a@a";
        string password;
        string name;
        string surname;
        int age;
        float average;

        public Student()
        {

        }

        public Student(string username, string name, string surname, float average)
        {
            this.username = username;
            this.name = name;
            this.surname = surname;
            this.average = average;
        }

        public float Average
        {
            get { return average; }
            set { average = value; }
        }

        //  public int MyProperty { get; private set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SurName
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Username //readOnly
        {
            get { return username; }
        }

        public string Password  //writeOnly
        {
            set { password = value; }
        }

    }
