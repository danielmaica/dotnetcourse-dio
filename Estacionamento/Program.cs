using System.Globalization;
using Estacionamento.Models;

Parking parking = new()
{
  InitialPrice = 0,
  HourPrice = 0
};
List<Vehicle> vehicles = new();
int option = 0;
string? licensePlate = null;
NumberFormatInfo format = NumberFormatInfo.CurrentInfo;

Console.WriteLine("Digite o preço inicial:");
parking.InitialPrice = decimal.Parse(Console.ReadLine() ?? throw new Exception("Informe o preço inicial."));

// preco hora * tempo permanecido no estacionamento
Console.WriteLine("Digite o preço por hora:");
parking.HourPrice = Decimal.Parse(Console.ReadLine() ?? throw new Exception("Informe o preço por hora."));

while (option != 4)
{
  // menu
  Console.WriteLine(
    "Digite sua opção:\n" +
    "1 - Cadastrar veículo\n" +
    "2 - Remover veículos\n" +
    "3 - Listar veículos\n" +
    "4 - Encerrar"
  );
  option = Int32.Parse(Console.ReadLine() ?? throw new Exception("Digite uma opção."));

  switch (option)
  {
    case 1:
      Console.WriteLine("Digite a placa do veículo para estacionar:");
      licensePlate = Console.ReadLine() ?? throw new Exception("Digite uma placa.");
      Vehicle newVehicle = new()
      {
        LicensePlate = licensePlate
      };
      vehicles.Add(newVehicle);
      Console.WriteLine("Pressione uma tecla para continuar");
      Console.ReadLine();
      break;
    case 2:
      Console.WriteLine("Digite a placa do veículo para remover:");
      licensePlate = Console.ReadLine() ?? throw new Exception("Digite uma placa.");
      Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
      int hoursParked = Int32.Parse(Console.ReadLine() ?? throw new Exception("Digite em horas o estacionado."));

      Vehicle? vehicle = vehicles.Find(v => v.LicensePlate.Equals(licensePlate));
      if (vehicle != null)
      {
        vehicles.Remove(vehicle);
        Console.WriteLine($"O veículo {vehicle.LicensePlate} foi removido e o preço total foi de: R$ {parking.HourPrice * hoursParked}");
      }
      else
      {
        Console.WriteLine("Este veículo não está em nosso estacionamento.");
      }
      Console.WriteLine("Pressione uma tecla para continuar");
      Console.ReadLine();
      break;
    case 3:
      Console.WriteLine("Os veículos estacionados s5ão:");
      vehicles.ForEach(v =>
      {
        Console.WriteLine(v.LicensePlate);
      });
      break;
    case 4:
      Console.WriteLine("Obrigado pela confiança, volte sempre!");
      break;
    default:
      Console.WriteLine("Opção inválida, tente novamente!");
      break;
  }
}