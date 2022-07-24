using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_C_Sharp
{
    public class TipoDeDados
    {
        public void tipoDados()
        {
            int i = 10;
            float f = 13.5f;
            double d = 10.5;
            char c = 'a';
            String s = "texto";
            bool b = true;
            bool b2 = false;

            var cidade = "São Paulo";
            var idade = 30;
            const String pais = "Brasil"; // valor constante não pode ser alterado
            f = idade;
            f = (float)c; // casting de tipos
        }

    }
}
