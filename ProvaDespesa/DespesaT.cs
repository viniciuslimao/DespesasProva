using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaDespesa
{
    public class DespesaT
    {
        private int Dia;
        private int Mes;
        private float[] ValorD;
        private float[] ValorM;
        private int CPF;
        public int Total;
        public DespesaT(int dia, int mes, float valorM, int cpf, float valorD)
        {
            Dia = dia;
            Mes = mes;
            ValorD[3] = valorD;
            ValorM[3] = valorM;
            CPF = cpf;
        }
        public int getMes()
        {
            return Mes;
        }
        public float getValorD()
        {
            return ValorD[3];
        }
        public float getValorM()
        {
            return ValorM[3];
        }
        public int getDia()
        {
            return Dia;
        }
        public int getCPF()
        {
            return CPF;
        }
        public int totalizaMes(int x, int y, int z)
        {
            ValorM[z] = ValorD[x] + ValorD[y];
            return Total;
        }
        public override string ToString()
        {
            return $"Dia: {Dia}\n" + $"Mês: {Mes}\n" + $"Despesa do dia: {ValorD}\n" + $"CPF: {CPF}\n" + $"Sua despesa mensal foi: {Total}";
        }
    }
}
