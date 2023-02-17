using System.Text.RegularExpressions;

leituraTexto();
Console.ReadLine();

void leituraTexto()
{
    Console.WriteLine("Digite um texto:");
    string? textoDigitado = Console.ReadLine();
    Console.WriteLine("Esse texto foi digitado no console:");
    Console.WriteLine(textoDigitado);

    string textoSemEspacos = Regex.Replace(textoDigitado, @"\s", "");

    if (textoSemEspacos.Any())
    {
        List<string> quantidadePalavras = textoDigitado.Split(' ').ToList();
        Console.WriteLine($"> {textoSemEspacos.Length} caracteres, {quantidadePalavras.Count()} palavras.");
    }
    else
    {
        Console.WriteLine("Digite ao menos algo ;)");
        leituraTexto();
    }
}