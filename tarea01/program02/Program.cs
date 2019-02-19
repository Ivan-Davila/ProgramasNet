using System;

namespace program02
{
    class Program
    {
        static int Main(string[] args)
        {
            string t, 
            if(args.Length==0){
                Console.Clear();
                Console.WriteLine("Programa que permite al usuario compara una pizza");
                Console.WriteLine("Debes especificar la opcion deseada");
                Console.WriteLine("<Tamaño> <ingredientes> <cubierta> <para>");
                menu();
                return 1;
            }
            
        }

        static void menu(){
            Console.WriteLine("Tamaño: (P)equeña, (M)ediana, o (G)rande.");
            Console.WriteLine("Ingredientes: (EX)tra queso, (CH)ampiñones, (CL)avos, (CE)bolla.");
            Console.WriteLine("");
        }
    }
}
