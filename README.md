# Exemplo de Palíndromo em C#

Este projeto demonstra como verificar se uma palavra ou frase é um palíndromo usando C#.

## O que é um Palíndromo?

Um palíndromo é uma palavra, frase ou sequência que pode ser lida da mesma forma de frente para trás e de trás para frente, ignorando espaços, pontuação e diferenças entre maiúsculas e minúsculas.

### Exemplos de Palíndromos:
- arara
- ovo
- osso
- A base do teto desaba
- Anotaram a data da maratona

## Estrutura do Projeto

```
ExamplePalindromoC#/
├── Program.cs
├── PalindromeChecker.cs
├── README.md
└── ExamplePalindromoC#.csproj
```

## Como Executar

### Pré-requisitos
- .NET 6.0 ou superior instalado

### Executando o projeto

```bash
dotnet run
```

### Compilando o projeto

```bash
dotnet build
```

## Funcionalidades

- ✅ Verificação de palíndromos simples
- ✅ Ignorar espaços e pontuação
- ✅ Ignorar diferenças entre maiúsculas e minúsculas
- ✅ Interface de linha de comando interativa
- ✅ Validação de entrada

## Exemplo de Uso

```csharp
var checker = new PalindromeChecker();

// Exemplos simples
Console.WriteLine(checker.IsPalindrome("arara")); // True
Console.WriteLine(checker.IsPalindrome("casa"));  // False

// Exemplos com espaços e pontuação
Console.WriteLine(checker.IsPalindrome("A base do teto desaba")); // True
Console.WriteLine(checker.IsPalindrome("Socorram-me, subi no ônibus em Marrocos")); // True
```

## Métodos Disponíveis

### `IsPalindrome(string text)`
Verifica se o texto fornecido é um palíndromo.

**Parâmetros:**
- `text` (string): O texto a ser verificado

**Retorna:**
- `bool`: `true` se for palíndromo, `false` caso contrário

### `CleanText(string text)`
Remove espaços, pontuação e converte para minúsculas.

**Parâmetros:**
- `text` (string): O texto a ser limpo

**Retorna:**
- `string`: Texto limpo contendo apenas letras em minúsculas

## Algoritmo

O algoritmo utiliza duas abordagens:

1. **Método de Comparação de String**: Remove caracteres especiais e compara a string com sua versão invertida
2. **Método de Dois Ponteiros**: Compara caracteres das extremidades movendo-se em direção ao centro

## Testes

Para executar os testes unitários:

```bash
dotnet test
```

## Contribuindo

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`)
3. Commit suas mudanças (`git commit -am 'Adiciona nova feature'`)
4. Push para a branch (`git push origin feature/nova-feature`)
5. Abra um Pull Request

## Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Autor

Desenvolvido como exemplo educacional para demonstrar conceitos de programação em C#.