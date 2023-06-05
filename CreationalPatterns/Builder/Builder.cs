
namespace Builder
{
    class Person
    {
        public string name;   // only reqired field
        public int age = -1;
        public string? occupation;
        public string? birthday;
        public string? favColour;

        public Person(string name)
        {
            this.name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"name: {name}");
            if (age >= 0)
            {
                Console.WriteLine($"age: {age}");
            }
            if (occupation != null)
            {
                Console.WriteLine($"occupation: {occupation}");
            }
            if (birthday != null)
            {
                Console.WriteLine($"birthday: {birthday}");
            }
            if (favColour != null)
            {
                Console.WriteLine($"favourite colour: {favColour}");
            }
            Console.WriteLine();
        }
    }

    class PersonBuilder
    {
        Person person;

        public PersonBuilder(string name)
        {
            person = new Person(name);
        }

        public PersonBuilder SetAge(int age)
        {
            person.age = age;
            return this;
        }

        public PersonBuilder SetOccupation(string occupation)
        {
            person.occupation = occupation;
            return this;
        }

        public PersonBuilder SetBirdthday(string birthday)
        {
            person.birthday = birthday;
            return this;
        }

        public PersonBuilder SetFavColour(string favColour)
        {
            person.favColour = favColour;
            return this;
        }

        public Person Build()
        {
            return person;
        }
    }

    class Builder
    {
        public static void Execute()
        {
            Person me = new PersonBuilder("Ben")
                .SetFavColour("Blue")   // methods can be called in any order
                .SetAge(19)
                .Build();
            me.DisplayInfo();

            Person bob = new PersonBuilder("Bob")
                .SetBirdthday("1st January")
                .SetAge(25)
                .SetFavColour("Red")
                .SetOccupation("Accountant")
                .Build();
            bob.DisplayInfo();
        }
    }
}
