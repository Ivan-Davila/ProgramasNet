using System;

namespace ControlBancario.Clases
{
    [Serializable]
    public class CuentaDeAhorros : CuentaBancaria //hereda de la clase Cuenta bancaria
    {
        private double tasa;
        public CuentaDeAhorros(int saldo, double tasa) : base(saldo) //invocamos constructor de la clase base
        {
            this.tasa=tasa;

        }
    }
}