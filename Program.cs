using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args){

            static float Calc(string param, float numOne, float numTwo){
                switch(param){
                    case "+":
                        return numOne + numTwo;
                    case "-":
                        return numOne - numTwo;
                    case "*":
                        return numOne * numTwo;
                    case "/":
                        return numOne / numTwo;
                    default:
                        Console.WriteLine("Houve um erro");
                        return 0;
                }
            }

            while(0 == 0){
                Console.WriteLine("----------Nova operação iniciada----------");
                Console.WriteLine();
                Console.WriteLine("Para adição, digite: +");
                Console.WriteLine("Para subtração, digite   : -");
                Console.WriteLine("Para multiplicação, digite: *");
                Console.WriteLine("Para divisão, digite: /");
                Console.WriteLine();

                Console.Write("Digite o tipo da operação: ");
                string? type = Console.ReadLine();

                    if(type == "Sair"){
                        Environment.Exit(0);
                    }else if(type == ""){
                        Console.Clear();
                        Console.WriteLine("-----Não conseguimos identificar a operação-----");
                        continue;
                    }

                Console.Write("Digite o primeiro fator: ");
                float numberOne = float.Parse(Console.ReadLine());


                Console.Write("Digite o segundo fator: ");
                float numberTwo = float.Parse(Console.ReadLine());
                
                Console.WriteLine($"O resultado da operação é : {Calc(type, numberOne, numberTwo)}");
                Console.WriteLine();
            }

        }
    }
}