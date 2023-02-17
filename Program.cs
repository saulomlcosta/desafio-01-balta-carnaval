leituraTexto();
Console.ReadLine();

void leituraTexto()
{
    Console.WriteLine("Digite um texto:");
    string? textoDigitado = Console.ReadLine();

    if (!string.IsNullOrEmpty(textoDigitado))
    {
        Console.WriteLine("Esse texto foi digitado no console:");
        Console.WriteLine(textoDigitado);

        Console.WriteLine($"> {textoDigitado.Length} caracteres, {textoDigitado.Split(' ').Length} palavras.");
    }
    else
    {
        Console.WriteLine("Digite ao menos algo ;)");
        leituraTexto();
    }
}