    using System; 
// Variáveis locais e globais
// Sobre Escopo:
    class Aula04{
static int num=10;
        static void Main(){
        int num2 =0;
        Console.WriteLine(num);
        } // Variável local já finalizada, logo, precisa declarar uma nova variável num.

    void teste(){
        int num3=0; // Mesmo com o mesmo nome e valor, elas não são a mesma variável. 
        Console.WriteLine(num);
        }
    } // Escopo de variáveis: onde essa variável é visível no código.