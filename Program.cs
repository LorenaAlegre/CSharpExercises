using System;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba una opcion:");
            
            string opcion = Console.ReadLine();
        
            switch (opcion)
            {
                case "1":
                ConsoleExercises console = new ConsoleExercises();
                console.AskAge();
                //Pedir nombre, apellido y documento e imprimir toda la información al final.
                break;

                case "2":
                VariableExercises variable = new VariableExercises();
                variable.Concatenador();
                break;

                case "3":
                DataTypeExercises dataType = new DataTypeExercises();
                dataType.ValueSum();
                break;
            }
        
        }
    }
}
