namespace DotnetCourse.Common.Models;

/// <summary>
/// Representa uma pessoa física
/// </summary>
public class Pessoa
{
  public string Name { get; set; } = string.Empty;
  public int Age { get; set; }

  public void Apresentar()
  {
    Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.");
  }

}
