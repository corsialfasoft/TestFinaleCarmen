using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi {
    class Esercizio1 {
        static void Main(string[] args) {
            int n = 0;
            int s = NumeriPari(n);
            NumeriDispari(s);
        }
        public static int NumeriPari(int n){ 
            for (int i=0; i<=14; i++){
                n = n+2;
                Console.WriteLine($"{n}");
            }
            return n;
        }
        public static void NumeriDispari(int s){ 
            int r = s+1;
            int a = s+1;
            
            int i = s+1;
            for (i=a; r>=2; i--){
                r = r-2;
                Console.WriteLine($"{r}");
            }
        }
    }
}
