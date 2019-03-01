using System;
using Redes.Clases;

namespace Redes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Red miRed = new Red("Red Patito","Mr Pato","Av.Priceton 123, Orlando Florida");
            Console.WriteLine("Datos generales de la Red:");
            
            miRed.AgregarNodo(new Nodo("192.168.0.10","servidor","5","10","Linux"));
            miRed.AgregarNodo(new Nodo("192.168.0.12","Equipo activo","2","12","IOS"));
            miRed.AgregarNodo(new Nodo("192.168.0.20","Computadora","8","5","Windows"));
            miRed.AgregarNodo(new Nodo("192.168.0.15","servidor","10","22","Linux"));

            Vulnerabilidad vlnd1 = new Vulneravilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar codigo arbitrario","remota","04/14/2015");
            Vulnerabilidad vlnd2 = new Vulneravilidad("CVE-2017-0004","microsoft","El servidor LSASS permite causar una denegacion de servicio","local","01/10/2001");
            Vulnerabilidad vlnd3 = new Vulneravilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS","remota","02/21/2017");
            Vulnerabilidad vlnd4 = new Vulneravilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1","local","11/13/2009");
            Vulnerabilidad vlnd5 = new Vulneravilidad("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold","local","12/20/2016");
            Vulnerabilidad vlnd6 = new Vulneravilidad("CVE-2017-2996","adobe","Adobe Flash Player 24.0.0.194 corrupción de memoria explotable","remota","15/02/2017");

            miRed.Nodos[0].AgregarVlnd(vlnd1);
            miRed.Nodos[0].AgregarVlnd(vlnd2);
            miRed.Nodos[1].AgregarVlnd(vlnd3);
            miRed.Nodos[2].AgregarVlnd(vlnd4);
            miRed.Nodos[2].AgregarVlnd(vlnd5);
            miRed.Nodos[2].AgregarVlnd(vlnd6);


            //imprimir reporte
            Console.WriteLine($"Empresa: {miRed.Empresa}");
            Console.WriteLine($"Propietario: {miRed.Propietario}");
            Console.WriteLine($"Domicilio: {miRed.Domicilio}");

            Console.WriteLine($"IP: {miRed.Nodos[0].Ip}");
        }
    }
}
