using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi {
    class Esercizio2 {
        static void Main(string[] args) {
            string frase = "ancora non ho fatto niente ancora non ho fatto niente ancora non ho fatto niente";
            int conta = ContaParole(frase);
        }
        public static int ContaParole(string frase){ 
            List<string> ElencoParole = new List<string>();
            int conta = 0;
            foreach(char c in frase){ 
                if (c == ' ') conta++;
                
                conta = conta+2;
                Console.WriteLine($"{frase}");
                return conta;
            }
        }
    }
}
