
string palavraSecreta;
string letra;
string resultado;

Console.Write("--- Forca ---\n");
Console.Write("Qual a palavra secreta? ");
palavraSecreta = Console.ReadLine()!.ToUpper()!;

while (true)
{
    Console.Write("Qual a letra? ");
    letra = Console.ReadLine()!.ToUpper();

    if (letra.Length == 1)
    {
        resultado = palavraSecreta.Contains(letra) ? "Existe" : "Não existe";
        Console.WriteLine($"A letra \"{letra}\" existe na palavra secreta? Resultado... {resultado}");

        break;
    }


    else
    {
        Console.WriteLine("Digite somente uma letra");
    }
}