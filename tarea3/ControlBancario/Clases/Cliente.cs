namespace ControlBancario.Clases
{
    public class Cliente
    {
        private string nombre;

        private CuentaBancaria cuenta;

        public Cliente(string nombre){
            this.nombre = nombre;
        }

        //propfull para generar el get-set

        public string Nombre
        {
            get { return nombre;}
        }

        
        public CuentaBancaria Cuenta
        {
            get { return cuenta;}
            set { cuenta = value;}
        }
        

        
    }
}