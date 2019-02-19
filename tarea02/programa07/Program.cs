using System;

namespace programa07
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A;
            int n;
            double may, men, med, var, des;


            Console.WriteLine("Programa que lee un arreglo de n elementos y realiza calculos");
            Console.WriteLine("Cuantos elementos ? "); n = int.Parse(Console.ReadLine());
            A= new double[n];
             Console.WriteLine("Dame los numeros del arreglo \n");
             Leer(A);

             //calculos
             may = Mayor(A);
             men = Menor(A);
            med = Media(A);
            var = Varianza(A,med,n);
            des = Math.Sqrt(var);

             //Salida
            Console.WriteLine("\nArreglo ");Imprime(A); 
            Console.WriteLine($"\nMayor {may}"); 
             Console.WriteLine($"\nMenor {men}"); 
              Console.WriteLine($"\nMedia {med}"); 
              Console.WriteLine($"\nVarianza {var}"); 
              Console.WriteLine($"\nDesviacion {des}"); 

        }
       
        static double Varianza(double[] v, double media, int n){
            double s=0;
            for(int i=0; i<v.Length; i++)
                s+= Math.Pow( (v[i]-media), 2);
            return (s/(n-1));
        }

        static double Media(double[] v){
            double s=0;
            for(int i=0; i<v.Length; i++)
                s+=v[i];
            return (s/v.Length);
        }
        static double Mayor(double[] v){
            double m=v[0];
            for(int i=0; i<v.Length; i++)
            if(v[i]>m) m=v[i];
            return m;
        }
        static double Menor(double[] v){
            double m=v[0];
            for(int i=0; i<v.Length; i++)
            if(v[i]<m) m=v[i];
            return m;
        }

         static void Imprime(double[] v)
        {
            for(int i=0; i<v.Length; i++)
             Console.WriteLine($"{v[i]} ");
        }

        static void Leer(double[] v)
        {
            for(int i=0; i<v.Length; i++){
                Console.WriteLine($"Elemento {i+1} = ");
                v[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
