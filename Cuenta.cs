using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ejerciciosPOO
{
    class Cuenta
    {
        private int vNumeroCuenta;
        private long vSaldo;

        public Cuenta(int pNumeroCuenta, long pSaldo)
        {
            this.vNumeroCuenta = pNumeroCuenta;
            this.vSaldo = pSaldo;
        }
        public int NumeroCuenta
        {
            get { return vNumeroCuenta; }
            private set { }
        } 
        public long Saldo
        { get { return vSaldo; }
            private set { }
        }
        public void recibirAbono(long pAbono)
        { vSaldo += pAbono; }
        public void pagarRecibos(long pRecibo)
        { vSaldo -= pRecibo; }
    }
    class Persona
    {
        private string vDNI;
        private Cuenta[] vCuentas= new Cuenta[3];

        public Persona(string pDNI)
        {
            vDNI = pDNI;
        }
        public string DNI
        {
            get { return vDNI; }
            private set { }
        }
        public Cuenta[] Cuentas
        {
            get { return vCuentas; }
            private set { }
        }
        public bool AgregarCuentas(Cuenta pCuenta)
        {
            int cuentaActual = -1;
            for (int i = 0; i < vCuentas.Length; i++)
            {
                if (vCuentas[i] == null && cuentaActual == -1)
                {
                    cuentaActual = i;
                }
            }
            if (cuentaActual != -1)
            {
                vCuentas[cuentaActual] = pCuenta;
                return true;
            }
            else
                return false;
        }
        public bool EsMorosa()
        {
            bool vMoroso = false;
            for (int i = 0; i < vCuentas.Length; i++)
            {
                if (vCuentas[i]!=null)
                {
                    if (vCuentas[i].Saldo < 0)
                    { vMoroso = true; }
                }
            }
            return vMoroso;
        }
    }
    class PruebaCuenta
    {
        public void ProbarCuenta()
        {
            Persona unaPersona = new Persona("12345678R");
            Cuenta unaCuenta = new Cuenta(123456, 0);
            Cuenta otraCuenta = new Cuenta(123457, 700);
            unaPersona.AgregarCuentas(unaCuenta);
            unaPersona.AgregarCuentas(otraCuenta);
            unaPersona.Cuentas[0].recibirAbono(1100);
            unaPersona.Cuentas[1].pagarRecibos(750);
            Console.WriteLine("Es morosa {0}",unaPersona.EsMorosa());
            unaPersona.Cuentas[0].pagarRecibos(100);
            unaPersona.Cuentas[1].recibirAbono(100);
            Console.WriteLine("Es morosa {0}", unaPersona.EsMorosa());
        }

    }
}
