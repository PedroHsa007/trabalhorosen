var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibNumbers)
{
    Console.Write($"{element} ");
}


// Span<int> numbers = new int[] { 3, 14, 15, 92, 6 };
//foreach (int number in numbers)
//{
//Console.Write($"{number} ");
//}

var nomes = new List<string>() { "Jose", "Tania", "Pedro" };
foreach(string nome in nomes)
{
    Console.WriteLine(nome);
}