using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraImp
    {
        private readonly List<string> _listaDeHistorico;
        public DateTime Data { get; set; }

        public CalculadoraImp(DateTime data)
        {
            Data = data;
            _listaDeHistorico = new List<string>();
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            InserirNoHistorico(resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            _listaDeHistorico.RemoveRange(3, _listaDeHistorico.Count - 3);
            return _listaDeHistorico;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            InserirNoHistorico(resultado);
            return resultado;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            InserirNoHistorico(resultado);
            return resultado;
        }

        private void InserirNoHistorico(int resultado)
        {
            _listaDeHistorico.Insert(0, "Res: " + resultado +", data: "+ Data);
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            InserirNoHistorico(resultado);
            return resultado;
        }
    }
}
   