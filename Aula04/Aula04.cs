    using System; 

// Variáveis Globais são aquelas declaradas no início de um algoritmo. Podem ser utilizadas no algoritmo principal e por todos os outros subalgoritmos. 
// Variáveis Locais são aquelas declaradas no início de um subalgoritmo.
// Escopo de variáveis: onde essa variável é visível no código.


static int num=10;
        static void Main(){
            int num2 =0;
            Console.WriteLine(num);
        } // Variável local já finalizada, logo, precisa declarar uma nova variável num.

        void teste(){
            int num3=0; // Mesmo com o mesmo nome e valor, elas não são a mesma variável. 
                Console.WriteLine(num);
        }
    