using System;

namespace CSharpExercises{
    public class ConsoleExercises {
        public void AskAge(){
            Console.WriteLine("¿Cuántos años tenes?: ");
            string age = Console.ReadLine();
            Console.WriteLine("Wow, no pareces de " + age + " años");

            Console.WriteLine("¿Como es tu nombre?");
            string name = Console.ReadLine();
            
            Console.WriteLine("¿Y apellido?");
            string apellido = Console.ReadLine();

            Console.WriteLine("Escribi tu DNI");
            string dni = Console.ReadLine();

            Console.WriteLine("Tu nombre es {0}, tu apellido es {1} y tu DNI es {2}", name, apellido, dni);


            Console.ReadLine();
        }
    }
}