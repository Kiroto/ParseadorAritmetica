// See https://aka.ms/new-console-template for more information
using Antlr4.Runtime;

namespace ParseadorAritmetica;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Parser Started");

        string input = "";
        while (input.ToLower() != "q")
        {
            input = Console.ReadLine();
            if (input is null) { input = ""; continue; }
        
            ICharStream charStream = CharStreams.fromString(input);
            aritmeticaLexer lexer = new aritmeticaLexer(charStream);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            aritmeticaParser parser = new aritmeticaParser(tokens);
            var actx = parser.aritmetica();
            Aritmetica aritmetica = new Aritmetica();
            var op = aritmetica.Visit(actx);
        }
    }
}