string nome;
string sobrenome;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()??"";

Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()??"";

Console.Write("Seu nome é: ");
Console.WriteLine($"{nome} {sobrenome}");

Console.Write("Em catálogo fica: ");
Console.WriteLine($"{sobrenome.ToUpper()}, {nome}");