using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExamplePalindromoC_
{
    /// <summary>
    /// Classe responsável por verificar se um texto é um palíndromo
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Verifica se o texto fornecido é um palíndromo
        /// </summary>
        /// <param name="text">Texto a ser verificado</param>
        /// <returns>True se for palíndromo, False caso contrário</returns>
        public bool IsPalindrome(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;
            
            string cleanedText = CleanText(text);
            
            if (cleanedText.Length <= 1)
                return true;
            
            // Método 1: Comparação com string invertida
            return IsPalindromeByStringComparison(cleanedText);
            
            // Método alternativo: Dois ponteiros (descomente para usar)
            // return IsPalindromeByTwoPointers(cleanedText);
        }
        
        /// <summary>
        /// Remove espaços, pontuação, acentos e converte para minúsculas
        /// </summary>
        /// <param name="text">Texto a ser limpo</param>
        /// <returns>Texto limpo contendo apenas letras em minúsculas</returns>
        public string CleanText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            
            // Remove acentos
            string normalizedText = RemoveAccents(text);
            
            // Remove tudo que não for letra e converte para minúsculas
            string cleanedText = Regex.Replace(normalizedText, @"[^a-zA-Z]", "").ToLower();
            
            return cleanedText;
        }
        
        /// <summary>
        /// Verifica palíndromo comparando com a string invertida
        /// </summary>
        /// <param name="cleanText">Texto já limpo</param>
        /// <returns>True se for palíndromo</returns>
        private bool IsPalindromeByStringComparison(string cleanText)
        {
            string reversedText = new string(cleanText.Reverse().ToArray());
            return cleanText.Equals(reversedText, StringComparison.OrdinalIgnoreCase);
        }
        
        /// <summary>
        /// Verifica palíndromo usando técnica de dois ponteiros
        /// </summary>
        /// <param name="cleanText">Texto já limpo</param>
        /// <returns>True se for palíndromo</returns>
        private bool IsPalindromeByTwoPointers(string cleanText)
        {
            int left = 0;
            int right = cleanText.Length - 1;
            
            while (left < right)
            {
                if (cleanText[left] != cleanText[right])
                    return false;
                
                left++;
                right--;
            }
            
            return true;
        }
        
        /// <summary>
        /// Remove acentos de caracteres
        /// </summary>
        /// <param name="text">Texto com possíveis acentos</param>
        /// <returns>Texto sem acentos</returns>
        private string RemoveAccents(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();
            
            foreach (var c in normalizedString)
            {
                var unicodeCategory = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }
            
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        
        /// <summary>
        /// Obtém estatísticas sobre o texto analisado
        /// </summary>
        /// <param name="originalText">Texto original</param>
        /// <returns>String com estatísticas</returns>
        public string GetTextStatistics(string originalText)
        {
            if (string.IsNullOrWhiteSpace(originalText))
                return "Texto vazio";
            
            string cleanText = CleanText(originalText);
            bool isPalindrome = IsPalindrome(originalText);
            
            var stats = new StringBuilder();
            stats.AppendLine($"Texto original: {originalText.Length} caracteres");
            stats.AppendLine($"Texto limpo: {cleanText.Length} caracteres");
            stats.AppendLine($"É palíndromo: {(isPalindrome ? "Sim" : "Não")}");
            
            if (isPalindrome && cleanText.Length > 0)
            {
                stats.AppendLine($"Ponto central: posição {cleanText.Length / 2}");
            }
            
            return stats.ToString();
        }
    }
}
