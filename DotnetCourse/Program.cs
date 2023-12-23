using System.Security.Cryptography;
using DotnetCourse.Common.Models;

int[] numeros = new int[3];
List<int> inteiros = new();

for (int c = 0; c < numeros.Length; c++)
{
  numeros[c] = RandomNumberGenerator.GetInt32(1, 10);
}

foreach (int num in numeros)
{
  inteiros.Add(num);
}

inteiros.ForEach(n =>
{
  Console.WriteLine(n);
});
