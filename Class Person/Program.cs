
using System;

namespace PPP
{

    class Person
    {
        DateTime mydate;
        //поля
        private string name;
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; } // get method
            set
            {   //чи правильний формат дати в стрічці?
                    if (value > DateTime.Parse("01.01.1800"))
                    birthDate = value;
            } // set method
        }
        //методи
        public Person(string name, DateTime birthDate)
        {   this.name = name;
            BirthDate = birthDate;
        }
        public Person()
        {
            this.name = "none";
            this.BirthDate = DateTime.Parse("01.01.1900");
        }
        public int Age()
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if (birthDate > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age;

        }
        //Метод інпут - це ввід даних про особу з консолі
        public void Input()
        {
            Console.WriteLine("Введіть ім'я");
            this.name = Console.ReadLine();
            Console.WriteLine("Введіть дату народження");
            this.BirthDate = DateTime.Parse(Console.ReadLine());
        }
        // void коли нічого не ретурнить 
        public String ChangeName()
        {
            Console.WriteLine("Введіть нове ім'я");
            name = Console.ReadLine();
            return name;
        }
        public string ToString(int i)
        {
            return $"Ім'я користувача: {name:F0} Дата народження: {birthDate: dd.MM.yyyy}";
        }
        //вивести інформацію про особу (виклик ToString())
        public void Output()
        {
            Console.WriteLine(ToString(1));
        }
        public static bool operator == (Person p1, Person p2)
        {
            if (p1.name == p2.name)
                return true;
            else 
                return false;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            if (p1.name != p2.name)
                return true;
            else
                return false;
        }
        static void Main(string[] args)

        {
            int myage;
            Person Person1 = new Person();
            Person Person2 = new Person();
            Person Person3 = new Person();
            Person Person4 = new Person();
            Person Person5 = new Person();
            Person Person6 = new Person();
            
            Person1.Input();
            Person2.Input();
            Person3.Input();
            Person4.Input();
            Person5.Input();
            Person6.Input();
            myage = Person1.Age();
            //не видно ім'я молодої персони
            if (Person1.Age() < 16) Console.WriteLine($"{Person1.name} is Very Young");
            myage = Person2.Age();
            if (myage < 16) Console.WriteLine($"{Person2.name} is Very Young");
            myage = Person3.Age();
            if (myage < 16) Console.WriteLine($"{Person3.name} is Very Young");
            myage = Person4.Age();
            if (myage < 16) Console.WriteLine($"{Person4.name} is Very Young");
            myage = Person5.Age();
            if (myage < 16) Console.WriteLine($"{Person5.name} is Very Young");
            myage = Person6.Age();
            if (myage < 16) Console.WriteLine($"{Person6.name} is Very Young");

            Person1.Output();
            Person2.Output();
            Person3.Output();
            Person4.Output();
            Person5.Output();
            Person6.Output();


            if (Person1 == Person2) Console.WriteLine("персони рівні");
            else Console.WriteLine("персони НЕ рівні");
            if (Person2 == Person3) Console.WriteLine("персони рівні");
            else Console.WriteLine("персони НЕ рівні");
            if (Person3 == Person4) Console.WriteLine("персони рівні");
            else Console.WriteLine("персони НЕ рівні");

            Console.WriteLine($"Вік: { Person1.Age()}");
            Console.WriteLine($"Вік: {Person1.Age()}");
            Person1.ChangeName();
            Console.WriteLine(Person1.ToString(1));
            Person1.Output();
        }

    }

}