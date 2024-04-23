int fibonacci, numero = 0, anterior = 1, proximo, atual = 0;


while (numero < 1)
{
    Console.Write("Digite até qual termo da sequência de fibonacci deseja ver (digite número 1 ou maior): ");
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine("Fibonnaci: "+0);
    for (int i = 2; i <= numero; i++)
    {
        proximo = anterior + atual;
        anterior = atual;
        atual = proximo;
        Console.WriteLine($"Fibonnaci: {atual}");
    }
}


