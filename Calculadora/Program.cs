float n1, n2;

Console.Write("Digite o valor para  N1: ");
n1 = float.Parse(Console.ReadLine());

﻿double num1, num2;
int opcao = 0;

Console.Write("Digite o valor para  N2: ");
n2 = float.Parse(Console.ReadLine());

float soma = n1 + n2;
float diferenca = n1 - n2;
float produto = n1 * n2;
float quociente;

if (n2 != 0)
{
    quociente = n1 / n2;

    Console.Write("Resultado da soma = {0}\n" +
    "Resultado da diferença = {1}\n" +
    "Produto = {2}\n" +
    "Quociente = {3}", soma, diferenca, produto, quociente);

}
else
{
    Console.WriteLine("Impossível divisão por ZERO!");
}