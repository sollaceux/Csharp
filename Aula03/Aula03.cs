using System;

class Aula03{

    static void Main(){
        byte n1=10; // 0 e 255
        int num=10;
        char letra='c';
        float valor=5.3f;
        string nome="Raphaela";

        var aux=nome; // não precisa especificar o tipo de var (recebe o valor de acordo com a atribuição)


            Console.WriteLine("Valor da variável: "+aux);

        int num1,num2;

        num1=10;
        num2=2;
        

            Console.WriteLine("A multiplicação de " +num1+ " x " +num2+ " é igual a: " +num1*num2);
    }
}