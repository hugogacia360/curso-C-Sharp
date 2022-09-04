using curso.Models;

string cidade = "São Paulo";
int quantidade = 10;
double preco = 10.50;
decimal valor = 10.50m;
bool ativo = true;

Console.WriteLine("A cidade é: " + cidade);
Console.WriteLine("A quantidade é: " + quantidade);
Console.WriteLine("O preço é: " + preco.ToString("0.0000"));
Console.WriteLine("O valor é: " + valor);
Console.WriteLine("O ativo é: " + ativo);

Pessoa p1 = new Pessoa();

p1.Nome = "Hugo";
p1.Idade = 20;

p1.Apresentar();