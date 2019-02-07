using System;

namespace PagaTrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int horas;
            float pagabruta, impuesto,paganeta,paga, tasa=0.1f;
            //Console.Clear();
            Console.WriteLine("Programa para calcular la paga de un rabajador");
            //entrada
            Console.Write("Nombre del trabajador: "); nombre=Console.ReadLine();
            Console.Write("Horas Trabajadas    : "); horas=int.Parse(Console.ReadLine());
            Console.Write("Paga por Hora       : "); paga=int.Parse(Console.ReadLine());
            
            pagabruta = horas * paga;
            impuesto = pagabruta * tasa;
            paganeta = pagabruta - impuesto;
            
            Console.Write($"El trabajador {nombre} trabajo {horas} horas,"); 
            Console.Write($"con un pago de {paga} por hora");
            Console.Write($" y recive una paga neta de: {paganeta}, con un impuesto de {impuesto} rebajado de su paga bruta de {pagabruta}"); 
        }
    }
}
