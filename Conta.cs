using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_Exercicio_2
{
    class Conta
    {
        private string Nome;
        private string Cpf;
        private int Num_C;
        private int Num_A;
        private double Saldo;
        private double Limite;
        private double Valor;


        public void Set_Nome(string Nome)
        {
            this.Nome = Nome;
        }

        public string Get_Nome()
        {
            return this.Nome;
        }

        public void Set_Cpf(string Cpf)
        {
            this.Cpf = Cpf;
        }

        public string Get_Cpf()
        {
            return this.Cpf;
        }

        public void Set_NumC(int Num_C)
        {
            this.Num_C = Num_C;
        }

        public int Get_NumC()
        {
            return this.Num_C;
        }

        public void Set_NumA(int Num_A)
        {
            this.Num_A = Num_A;
        }

        public int Get_NumA()
        {
            return this.Num_A;
        }

        public void Set_Saldo(double Saldo)
        {
            this.Saldo = Saldo;
        }

        public double Get_Saldo()
        {
            return this.Saldo;
        }

        public void Set_Limite(double Limite)
        {
            this.Limite = Limite;
        }

        public double Get_Limite()
        {
            return this.Limite;
        }
        /////
        ///
        public void Dep(double Valor)
        {
            if (Limite >= 100)
            {
                Saldo = Saldo + Valor;
            }
            else
            {                
                if (Limite < 100)
                {
                    Limite = Limite + Valor;

                    if(Limite > 100 )
                    {
                        Saldo = Saldo + (Limite - 100);
                        Limite -= Saldo;
                    }
                }
            }
        }

public void Saq(double Valor)
        {
            if (Valor <= Saldo)
            {
                this.Saldo = Saldo - Valor;
            }
            else
            {
                if(Valor <= (Saldo + Limite))
                {
                    Limite = (Limite + Saldo) - Valor;
                    Saldo = 0;
                }
                
                //if (Valor <= (Saldo + Limite))
                //{
                //    Saldo = Saldo - Valor;
                //    Limite = Limite - (Saldo * -1);
                //    if (Saldo < 0)
                //    {
                //        Saldo = 0;
                //    }
                //}
            }
        }
    }
}

