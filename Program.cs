Console.Clear();
Console.WriteLine("--- Pet Hotel Check-in ---\n");

Console.Write("Espécie.....: ");
string especie = Console.ReadLine()!;

Console.Write("Raça.....: ");
string raca = Console.ReadLine()!;

Console.Write("Alcuna.....: ");
string nome = Console.ReadLine()!;

Console.Write("Idade.....: ");
string idade = Console.ReadLine()!;

Console.Write("Pelagem/Cor.....: ");
string pelagem = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("+=========================================================+");
Console.Write("|                  ");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("Pet Hotel \"Nem Um Pio\"");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("                 |");

Console.WriteLine("+=========================================================+");
Console.Write("| Especie: ");
Console.ResetColor();
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" | Raça: ");
Console.ResetColor();
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" |");

Console.WriteLine("+=========================================================+");
Console.Write("| Atende pelo nome de: ");
Console.ResetColor();
Console.Write(nome.Trim().ToUpper().PadLeft(34, '.').Substring(0, 34));
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" | ");

Console.WriteLine("+=========================================================+");
Console.Write("| Idade: ");
Console.ResetColor();
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(" | Pelagem/Cor: ");
Console.ResetColor();
Console.Write(pelagem.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" |");
Console.WriteLine("+=========================================================+");



Console.ResetColor();
Console.ForegroundColor = ConsoleColor.White;






