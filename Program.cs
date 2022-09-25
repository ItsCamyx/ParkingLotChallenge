using ParkingLot.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento SafeStop!\n\n" +
                "Para iniciar o programa por gentileza,\n" +
                "digite abaixo o preço fixo de entrada no estacionamento:\n" +
                "Obs: Se não houver preço fixo, digite o valor 0 (zero)\n");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Para ir ao Gerenciamento do estacionamento\n" +
                "Digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("******** Gerenciamento do estacionamento ********\n");
    Console.WriteLine("Digite a sua opção:\n");
    Console.WriteLine("1 - Cadastrar entrada de veículo no estacionamento");
    Console.WriteLine("2 - Remover Cadastro de veículo no estacionamento");
    Console.WriteLine("3 - Listar veículos ativos no estacionamento\n");
    Console.WriteLine("******** Área de encerramento de expediente ********");
    Console.WriteLine("4 - Encerrar o expediente / deslogar\n");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("Você encerrou o expediente");
