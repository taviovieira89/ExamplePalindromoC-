using System;

namespace ExamplePalindromoC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Verificador de Palíndromos ===\n");
            
            var checker = new PalindromeChecker();
            
            // Exemplos automáticos
            Console.WriteLine("Exemplos automáticos:");
            TestPalindrome(checker, "arara");
            TestPalindrome(checker, "casa");
            TestPalindrome(checker, "ovo");
            TestPalindrome(checker, "A base do teto desaba");
            TestPalindrome(checker, "Anotaram a data da maratona");
            TestPalindrome(checker, "Socorram-me, subi no ônibus em Marrocos");
            TestPalindrome(checker, "programação");
            
            Console.WriteLine("\n" + new string('-', 50));
            
            // Interface interativa
            Console.WriteLine("\nModo Interativo - Digite suas próprias palavras/frases:");
            Console.WriteLine("(Digite 'sair' para encerrar)\n");
            
            while (true)
            {
                Console.Write("Digite uma palavra ou frase: ");
                string? input = Console.ReadLine();
                
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Por favor, digite algo válido.\n");
                    continue;
                }
                
                if (input.ToLower() == "sair")
                {
                    Console.WriteLine("Obrigado por usar o verificador de palíndromos!");
                    break;
                }
                
                TestPalindrome(checker, input);
                Console.WriteLine();
            }
        }
        
        static void TestPalindrome(PalindromeChecker checker, string text)
        {
            bool isPalindrome = checker.IsPalindrome(text);
            string cleanText = checker.CleanText(text);
            
            Console.WriteLine($"Texto original: \"{text}\"");
            Console.WriteLine($"Texto limpo: \"{cleanText}\"");
            Console.WriteLine($"É palíndromo? {(isPalindrome ? "✅ SIM" : "❌ NÃO")}");
            Console.WriteLine();
        }
    }
}