using System;

namespace program01
{
    class Program
    {
        static int Main(string[] args)
        {
            int op,c,sum=0;
            Console.Clear();
            if(args.Length==0){
                Console.WriteLine("Programa que ejemplifica el uso de ciclos y estucturas de control en c#");
                Console.WriteLine("Debes espicificar la opcion deseada");
                menu();
                return 1;
            }

            op=int.Parse(args[0]);
            switch(op){
                case 1: {
                    c=1;
                    while(c<=100){
                        Console.Write($"{c} ");
                        sum+=c++;
                    }

                }break;
                case 2: {
                    c=100;
                    while(c>0){
                        Console.Write($"{c} ");
                        sum+=c--;
                    }

                }break;
                case 3: {
                    for(int i=50;i<=200;i++){
                        sum+=1;
                        Console.Write($"{i}");
                    }                   

                }break;
                case 4: {
                    for(int i=2;i<=100;i+=2){
                        sum+=1;
                        Console.Write($"{i}");
                    }
                }break;
                case 5:{
                    for(int i=99; i>=1;i-=2){
                        sum+=i;
                        Console.Write($"{i} ");
                    }
                }break;
                case 6:{
                    c=272;
                    while(c>=40){
                        Console.Write($"{c} ");
                        sum+=c;
                        c-=4;
                    }
                }break;
            }
            Console.WriteLine($"{sum}");
            return 0;
        }

        static void menu(){
            Console.WriteLine("[1] Numeros del 1 al 100 con ciclo while");
            Console.WriteLine("[2] Numeros del 100 al 1 con ciclo do .. while");
            Console.WriteLine("[3] Numeros del 50 al 200");
            Console.WriteLine("[4] Numeros del 2 al 100 solo los pares");
            Console.WriteLine("[5] Numeros del 99 al 1 solo los impares");
            Console.WriteLine("[6] Numeros del 272 al 40 en decrementos de 4");
        }
    }

}
