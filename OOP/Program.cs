using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        public abstract class rexAbstract //abstract class where we can define or declare parameters and methods
        {
            public virtual void numarAnimale() {
                Console.WriteLine("Still no animals");
            }
            public abstract string nume { get; set; }
        }
        public interface Irex //interface where is a list where are declared of all parameters and methods without a body
        {
            string nume { get; set; }
            void speak(); //we know we have a method speak, but we don t know what it does
        }
        class rex : rexAbstract, Irex //encapsulation
        {
            public rex()
            {
                
            }
            public static int nrAnimale = 0;

            public override string nume { get; set; }
            protected int varsta;    //protected so it can be used in subclass Caine
            private int nrPicioare;  //can modify just in this class

            string Irex.nume { get; set; } //some auto complete code to get rid of errors...getters and setters for variables from interface

            public override void numarAnimale() //overrides from abstract class
            {
                Console.WriteLine(nrAnimale);
            }
            public virtual void speak()
            {
                Console.WriteLine("Make a sound!");
            }
            public void setVarsta(int age)
            {
                varsta = age;
                Console.WriteLine($"Am {varsta} ani");
            }
            public int getPicioare()
            {
                return nrPicioare;
            }
            public void setPicioare(int nr)
            {
                nrPicioare = nr;
            }
            public void setPicioare() //overload
            {
                nrPicioare = 0;
            }
            public void mers()
            {
                if (nrPicioare == 4)
                {
                    Console.WriteLine("Merg in 4 labe");
                }
                if (nrPicioare == 2)
                {
                    Console.WriteLine("Sunt biped");
                }
                if (nrPicioare == 0)
                {
                    Console.WriteLine("Nu am picioare");
                }
                //or a switch
            }
        }
        class Caine : rex //inheritance
        {
            public Caine()
            {
                nrAnimale++;
            }
            public string rasa;
            public void varstaAnimal()
            {
                var varstaAnimal = varsta * 7;  //varsta from animal: protected
                Console.WriteLine($"Dar varsta mea reala este de {varstaAnimal} ani.");
            }
            public override void speak() //override/overwrite
            {
                Console.WriteLine("Ham Ham");
            }
        }
        class Pisica : rex
        {
            public Pisica()
            {
                nrAnimale++;
            }
            public override void speak()
            {
                Console.WriteLine("Meow Meow");
            }
        }

        class Cangur : rex
        {
            private bool pui;
            public Cangur()
            {
                nrAnimale++;
                pui = true;
            }
            public void marsupiu()
            {
                if (pui)
                {
                    Console.WriteLine("Sunt pui si nu am marsupiu...");
                }
                else
                {
                    Console.WriteLine("Sunt matur si am marsupiu");
                }
            }
            public void maturizare()
            {
                pui = false;
                Console.WriteLine("Am crescut");
            }
            public override void speak()
            {
                //base.speak();  //place the base class method
                Console.WriteLine("cough cough cough");
            }
            public void maPrezint()
            {
                Console.WriteLine($"Numele meu e {nume}");
            }
        }
        static void Main(string[] args)
        {
            rex animal = new rex();
            Console.Write("numar animale: ");
            animal.numarAnimale();
            animal.nume = "\"nume de animal\"";
            Console.Write($"{animal.nume} \n");
            animal.speak();         //method to be overrided using polymorphism

            Console.WriteLine();

            Caine rex = new Caine();
            rex.nume = "rex";       //can be accessed because it's plublic
            //rex.varsta = 0;       //error because it's protected and can only be accessed in the base class or subclasses => method varstaAnimal()
            Console.WriteLine($"Numele meu este {rex.nume}");
            rex.setPicioare(4);
            rex.mers();
            //Console.Write("Enter age: ");
            //rex.setVarsta( int.Parse(Console.ReadLine())); //input method
            rex.setVarsta(2);
            rex.varstaAnimal();     //method in subclass for protected variable: varsta
            rex.speak();

            Console.WriteLine();

            rex miti = new Pisica(); //works defining it as base class
            miti.nume = "miti";
            miti.setVarsta(5);
            Console.WriteLine($"Numele meu este {miti.nume}");
            miti.setPicioare();     //overload
            miti.mers();
            miti.speak();

            Console.WriteLine();

            Cangur kangu = new Cangur();
            kangu.nume = "sven";
            kangu.maPrezint();      //abstractization: hide details
            kangu.setVarsta(10);    //method for protected variable
            kangu.marsupiu();
            kangu.maturizare();     //method in class for private variabile: pui //kangu.pui = false; //error because "pui" property is private
            kangu.marsupiu();
            kangu.setPicioare(2);   //polymorphism: overload - same name and different inputs
            kangu.mers();           //different response for every animal
            kangu.speak();          //polymorphism: overrided - redefined in every class

            Console.Write("\nNr total animale: ");
            rex.numarAnimale();

            Console.ReadKey();
        }
    }
}
