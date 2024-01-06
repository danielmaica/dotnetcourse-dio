namespace DotnetCourse.Common.Models;

/// <summary>
/// Representa uma pessoa física
/// </summary>
public class Pessoa
{
  public Pessoa()
  {

  }

  public Pessoa(string name, string surname, int age)
  {
    Name = name;
    Surname = surname;
    Age = age;
  }

  private string _name;
  private int _age;

  public string Name
  {
    get => _name.ToUpper();
    set
    {
      if (value == "")
      {
        throw new ArgumentException("Um nome deve ser informado.");
      }
      _name = value;
    }
  }
  public string Surname { get; set; }
  public string FullName => $"{Name} {Surname}".ToUpper();
  public int Age
  {
    get => _age;
    set
    {
      if (value < 0)
      {
        throw new ArgumentException("A idade não pode ser menor que zero.");
      }
      _age = value;
    }
  }

  public void Apresentar()
  {
    Console.WriteLine($"Olá, meu nome é {FullName} e tenho {Age} anos.");
  }
}
