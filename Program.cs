Console.WriteLine("Olá, bem vindo ao Pet Hotel! Pressione uma tecla para prosseguirmos com o seu cadastro");
Console.ReadKey();

Console.WriteLine("Digite a espécie do seu Pet:");
string especie = Console.ReadLine()!;

Console.WriteLine("Digite a raça do seu Pet:");
string raca = Console.ReadLine()!;

Console.WriteLine("Digite o nome do seu Pet:");
string nome = Console.ReadLine()!;

Console.WriteLine("Digite a idade do seu Pet:");
int idade = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Digite a pelagem/cor do seu Pet:");
string pelagem = Console.ReadLine()!;


Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("+=========================================================+");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
Console.ResetColor();
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("+=========================================================+");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"| Espécie: {especie.PadLeft(18,'.')} | Raça: {raca.PadLeft(19, '.')} |");
Console.ResetColor();
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("+=========================================================+");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"| Atende pela alcunha de: {nome.PadLeft(31, '.')} |");
Console.WriteLine($"| Idade: {idade.ToString().PadLeft(2, '0')} ano(s) | Pelagem/cor: {pelagem.PadLeft(23, '.')} |");
Console.ResetColor();
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("+=========================================================+");
Console.ResetColor();

