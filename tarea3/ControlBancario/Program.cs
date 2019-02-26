using System;
using System.IO;
using ControlBancario.Clases;
namespace ControlBancario
{
    class Program
    {
        static void MainV1(string[] args)
        {/*
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
        */
        }

        static void Main(string[] args){

            Banco mibanco;
            
            string ruta= Directory.GetCurrentDirectory();
            string arch= "banco.dat";
            if(File.Exists(ruta+"/"+"banco.dat")){
                Console.WriteLine("Leyendo archivo");
                mibanco = new Banco();
                mibanco = Utilerias.Leer(arch);
            }
            
        else{
            Console.WriteLine("NO existe, creando");
            mibanco = new Banco("Mac Pato Ricon S.A.");
            mibanco.AgregarCliente(new Cliente("Vicente Fox"));
            mibanco.AgregarCliente(new Cliente("Felipe Beberon"));
            mibanco.AgregarCliente(new Cliente("Lord Peña"));
            mibanco.AgregarCliente(new Cliente("Cabecita Algodon"));

            mibanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(100,2000));
            mibanco.Clientes[1].AgregarCuenta(new CuentaDeCheques(200,1000));
            mibanco.Clientes[1].AgregarCuenta(new CuentaDeAhorros(300,0.5));
            mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorros(1300,5000));
            mibanco.Clientes[3].AgregarCuenta(new CuentaDeCheques(2000,15000));

            mibanco.Clientes[0].Cuentas[0].Retira(300);
            mibanco.Clientes[1].Cuentas[1].Deposita(600);
            mibanco.Clientes[3].Cuentas[1].Retira(5000);

            Utilerias.Grabar(mibanco,arch);
            }
            Console.WriteLine("-----Reporte General del banco-----");
            Console.WriteLine($"{mibanco.Nombre}"); 

            foreach (Cliente cte in mibanco.Clientes)
            {
                
                Console.WriteLine($"Cliente: {cte.Nombre}");
                Console.WriteLine("Cuentas");
                foreach (CuentaBancaria cta in cte.Cuentas)
                {
                    if(cta is CuentaDeAhorros){
                        Console.WriteLine($"Ahorros : saldo {cta.Saldo}");
                    }
                    else{
                        Console.WriteLine($"Cheques : saldo {cta.Saldo}");
                    }
                        Console.WriteLine();
                }
            }

            

        }

    }
}
