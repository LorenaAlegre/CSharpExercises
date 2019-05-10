using System;

namespace CSharpExercises{
    public class DataTypeExercises{
        public void ValueSum(){
            Console.WriteLine("Ingrese un valor a sumar:");
            var firstValue = Console.ReadLine();

            Console.WriteLine("Ingrese otro valor a sumar:");
            var secondValue = Console.ReadLine();
            
            int first = 0;
            int second = 0;
            bool couldParseFirst = Int32.TryParse(firstValue, out first);

            if(couldParseFirst){
                bool couldParseSecond = Int32.TryParse(secondValue, out second);
                if (couldParseSecond){

                    Console.WriteLine("El resultado de la suma es: {0}", first + second);
                }
            
            }else
            {
                Console.WriteLine("El segundo valor no es numerico");

            }
         else  {

                Console.WriteLine("El primer parametro esta mal formateado");
         }
                
            }
            }

            Console.WriteLine("El resultado de la suma es: {0}", int.Parse(firstValue) + int.Parse(secondValue));
        }
    }
}