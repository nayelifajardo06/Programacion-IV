using System;

namespace ProgIV_Deber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREAR 2 GATOS
            Cat catLuna = new Cat();
            Cat catMichu = new Cat();

            //ASIGNAR ESTADOS A CADA GATO
            catLuna.name = "Luna";
            catLuna.gender = "Hembra";
            catLuna.setAge(3);
            catLuna.setWeight(5);
            catLuna.color = "Blanco";

            catMichu.name = "Michu";
            catMichu.gender = "Hembra";
            catMichu.setAge(4);
            catMichu.setWeight(6);
            catMichu.color = "Marron";

            //CALCULOS DE LAS DOSIS DE CADA GATO
            float dosisLuna = catLuna.dosificar();
            float dosisMichu = catMichu.dosificar();

            //PUBLICAR LA TABLA DE DOSIS
            Console.WriteLine("TABLA DE DOSIS");
            Console.WriteLine(" - " + catLuna.name + " : " + dosisLuna);
            Console.WriteLine(" - " + catMichu.name + " : " + dosisMichu);
        }
    }
}
