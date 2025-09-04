using Lesson_3_NCD25;

namespace Lesson_3_NCD25
{
    /*
    public class Dog
    {

        public string Name;
        public int Age;

        public void bark()
        {
            Console.WriteLine($"{Name} said Voff voff"); 
        }

    }
*/

    public class Human
    {
        public string Name;
        public int Age;
        public double Length;
        public double Weight;

        public int stepsWalked = 0;

        public string greet;

        public void Intruduce()
        {
            Console.WriteLine($"Hi my name is {Name} and I'm {Age} years old. I'm {Length} meters tall and weight {Weight}kg");
        }

        public void Walk(int steps)
        {

            stepsWalked += steps;

            Console.WriteLine($"{Name} took {steps} steps. {Name} have walked a total of {stepsWalked}");
            
            

            //stepsWalked++; //om +=5 ta 5 steg per metod Walk
        }

        public void Greet(Human personToGreet)
        {

            

            Console.WriteLine($"{Name} said hello to {personToGreet.Name}");
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Hund 1
            Dog dog1 = new Dog();
            dog1.Name = "Rudolf";
            dog1.Age = 10;

            Console.WriteLine($"My dog {dog1.Name} is {dog1.Age} years old"); 
            dog1.bark();

            //Hund 2
            Dog dog2 = new Dog();
            dog2.Name = "Lex";
            dog2.Age = 17;

            Console.WriteLine($"My dog {dog2.Name} is {dog2.Age} years old");
            dog2.bark();

            //Hund 3
            Dog dog3 = new Dog();
            dog3.Name = "Kalle";
            dog3.Age = 18;

            Console.WriteLine($"My dog {dog3.Name} is {dog3.Age} years old");
            dog3.bark();

            //Hund 4
            Dog dog4 = new Dog();
            dog4.Name = "Mundo";
            dog4.Age = 1;

            Console.WriteLine($"My dog {dog4.Name} is {dog4.Age} years old");
            dog4.bark();

            Dog dog5 = new Dog();
            dog5.Name = "Adolf";
            dog5.Age = 8;

            Console.WriteLine($"My dog {dog5.Name} is {dog5.Age} years old");
            dog5.bark();

            Dog dog6 = new Dog();
            dog6.Name = "Tyson";
            dog6.Age = 6;

            Console.WriteLine($"My dog {dog6.Name} is {dog6.Age} years old");
            dog6.bark();
            */

            
            Human me = new Human();
            me.Name = "Joel";
            me.Age = 31;
            me.Length = 1.72;
            me.Weight = 75;

            me.Intruduce();
           

            Human brother1 = new Human();
            brother1.Name = "Jesper";
            brother1.Age = 33;
            brother1.Length = 1.80;
            brother1.Weight = 73;

            brother1.Intruduce();


            me.Greet(brother1);
            brother1.Greet(me);

            /*
            Human brother2 = new Human();
            brother2.Name = "Jonte";
            brother2.Age = 38;
            brother2.Length = 176;
            brother2.Weight = 84;

            Human mom = new Human();
            mom.Name = "Marie";
            mom.Age = 53;
            mom.Length = 1.67;
            mom.Weight = 73;

            Human dad = new Human();
            dad.Name = "Tore";
            dad.Age = 67;
            dad.Length = 184;
            dad.Weight = 93;
            */


        }
    }
}
