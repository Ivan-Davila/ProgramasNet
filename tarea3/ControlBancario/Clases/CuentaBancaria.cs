using System;

namespace ControlBancario.Clases
{
    [Serializable]
    public class CuentaBancaria
    {
        protected double saldo;//protected permite que las clases puedan utilizar 
        //se utiliza la sobrecarga en el constructor para poder inicializar con o sin valores la intancia del objeto
        //se distingue por que un metodo no tiene parametros de entrada y el segundo si aunque tengan el mismo nombre
        //se diferencia su uso mandando el parametro que requiera cada uno
        //no puede haber dos metodos con el mismo metodo y con los mismo parametros. (tipo o cantidad.)
        public CuentaBancaria(){}

        public CuentaBancaria(double saldo){
            this.saldo = saldo;
        }

        public double Saldo{
            get { return saldo;}
            set { saldo = value;}
        }

        public void Deposita(double cantidad){
            if (cantidad > 0) 
                saldo+=cantidad;
        }
        public virtual bool Retira(double cantidad){//virtual permite sobrecargar el metodo
            if(cantidad <= saldo){
                saldo-=cantidad;
                return true;
            }
            else return false;
        }
    }
}