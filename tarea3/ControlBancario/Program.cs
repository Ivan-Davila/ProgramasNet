using System;
using ControlBancario.Clases;
namespace ControlBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos primero una instancia de la clase pero no se inicializa, no se utiliza espacio de memoria
            CuentaBancaria micuenta;
            micuenta= new CuentaBancaria();

            //se crea la intancia y se inicializa en la misma linea
            CuentaBancaria MiOtraCuenta=new CuentaBancaria(300);
            
            micuenta.Saldo = 100;
            //MiOtraCuenta.Saldo = 300; con el constructor ya se puede inicializar con un saldo.

            micuenta.Deposita(50);            
            MiOtraCuenta.Deposita(10);
            
            //Creacion del cliente
            Cliente micliente = new Cliente("Juan Perez Diaz");
            micliente.Cuenta = micuenta;

            Cliente MiOtroCliente = new Cliente ("Maria Lopez Perez");
            MiOtroCliente.Cuenta = MiOtraCuenta;

            Cliente clientazo = new Cliente("Ivan Davila");
            clientazo.Cuenta = new CuentaBancaria(100000);


            if(MiOtraCuenta.Retira(150)){
                Console.WriteLine("Retiro exitoso");
            }
            else Console.WriteLine("Saldo insuficiente");
            
            Console.WriteLine($"Saldo de mi cuenta 1 {micuenta.Saldo}");
            Console.WriteLine($"Saldo de mi cuenta 2 {MiOtraCuenta.Saldo}");
            Console.WriteLine("Hello World!");

            //Imprimir datos del cliente y saldo de la cuenta:
            Console.WriteLine($"nombre y saldo de mi cuenta 1: {micliente.Nombre} {micliente.Cuenta.Saldo}");
            Console.WriteLine($"nombre y saldo de mi cuenta 1: {MiOtroCliente.Nombre} {MiOtroCliente.Cuenta.Saldo}");
            Console.WriteLine($"nombre y saldo de mi cuenta 1: {clientazo.Nombre} {clientazo.Cuenta.Saldo}");
        }
    }
}
