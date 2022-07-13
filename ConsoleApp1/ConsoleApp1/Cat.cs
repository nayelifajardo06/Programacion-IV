using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIV_Deber1
{
    internal class Cat
    {
        //ATRIBUTOS
        public String name;
        public String gender;
        private int age;
        private int weight;
        public String color;

        //METODOS
        public void setAge(int edad)
        {
            int edadMin = 1;
            int edadMax = 20;

            if (edadMin <= edad && edad <= edadMax)
            {
                age = edad;
            }else
            {
                throw new Exception("La edad no pertenece al rango permitido");
            }
        }

        public void setWeight(int peso)
        {
            int pesoMin = 1;
            int pesoMax = 10;

            if (pesoMin <= peso && peso <= pesoMax)
            {
                weight = peso;
            }
            else
            {
                throw new Exception("El peso no pertenece al rango permitido");
            }
        }

        public void breathe() { }
        public void eat(int foot) { }
        public void run(String destination) { }
        public void sleep(int hours) { }
        public void meow() { }

        // Dosis del medicamento se calcula en base de la edad y el peso del gato
        // 1 mg corresponde a gatos menores o iguales a 3 años y menores o iguales a 4 libras de peso
        // 2 mg corresponde a gatos menores o iguales a 5 años y menores o iguales a 7 libras de peso 
        // 3 mg corresponde a gatos mayores a 5 años y mayores de 7 libros
        public float dosificar()
        {
            float dosis = 0.0f;

            // CONDICION 1: menores o iguales a 3 años y menores o iguales a 4 libras de peso
            if ( age <= 3 && weight <= 4)
            {
                dosis = 1.0f;
            }
            //CONDICION 2: menores o iguales a 5 años y menores o iguales a 7 libras de peso
            else if ( age <= 5 && weight <= 7)
            {
                dosis = 2.0f;
            }
            //CONDICIO 3; para mayores a 5 años y mayores de 7 libros
            else if ( age > 5 && weight > 7)
            {
                dosis = 3.0f;
            }

            return dosis;
        }
    }
}
