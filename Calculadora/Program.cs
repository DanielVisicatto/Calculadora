double num1, num2;
int opcao = 0;

ReceberEntrada();
Escolher();

void ReceberEntrada()
{
    Console.Write("Informe o primeiro número: ");
    num1 = double.Parse(Console.ReadLine());

    Console.Write("Informe o segundo número: ");
    num2 = double.Parse(Console.ReadLine());
}
void Escolher()
{
    while (opcao >= 0 && opcao != 5)
    {
        Menu();
        switch (opcao)
        {
            default:
                Console.WriteLine("Opcao inválida");
                break;

            case 1:
                Console.WriteLine("A soma desses números é: {0}", Somar());
                break;
            case 2:
                Console.WriteLine("A diferenca desses números é: {0}", Subtrair());
                break;
            case 3:
                Console.WriteLine("O produto desses números é: {0}", Multiplicar());
                break;
            case 4:
                VerificarDivisaoPorZero();
                if (num2 > 0)
                    Console.WriteLine("O quociente desses números é: {0}", Dividir());
                break;
            case 5:
                Console.WriteLine("Obrigado por ultilizar nossos serviços!");
                break;
        }
        Console.ReadLine();
    }
}
int Menu()
{
    Console.Clear();
    Console.WriteLine("Selecione uma opcao desejada.");
    Console.WriteLine("1 - Somar\n" +
                      "2 - Subtrair\n" +
                      "3 - Multiplicar\n" +
                      "4 - Dividir\n" +
                      "5 - Sair;");
    return opcao = int.Parse(Console.ReadLine());
}
double Somar()
{
    double resultado = num1 + num2;
    return resultado;
}
double Subtrair()
{
    double resultado = num1 - num2;
    return resultado;
}
double Multiplicar()
{
    double resultado = num1 * num2;
    return resultado;
}
double Dividir()
{
    double resultado = num1 / num2;
    return resultado;
}
void VerificarDivisaoPorZero()
{
    if (num2 == 0)
    {
        Console.WriteLine("Impossível divisão por zero!");
    }

}