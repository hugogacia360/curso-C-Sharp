using curso.Models;

/* DateTime dataAtual = DateTime.Now;
string cidade = "São Paulo";
int quantidade = 10;
double preco = 10.50;
decimal valor = 10.50m;
bool ativo = true;
int a = Convert.ToInt32("5");
int b = int.Parse("5");
string c = 5.ToString();
string d = "15-";
int.TryParse(d, out int e);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine("A cidade é: " + cidade);
Console.WriteLine("A quantidade é: " + quantidade);
Console.WriteLine("O preço é: " + preco.ToString("0.0000"));
Console.WriteLine("O valor é: " + valor);
Console.WriteLine("O ativo é: " + ativo);
Console.WriteLine("A data atual é: " + dataAtual.ToString("dd/MM/yyyy HH:mm:ss"));

Pessoa p1 = new Pessoa();

p1.Nome = "Hugo";
p1.Idade = 20;

p1.Apresentar();
*/

Console.WriteLine("A quantidade em estoque");
int quantEstoque = int.Parse(Console.ReadLine());
Console.WriteLine("A quantidade vendida");
int quantVendida = int.Parse(Console.ReadLine());

if (quantEstoque >= quantVendida)
{
    Console.WriteLine("A quantidade em estoque é: " + (quantEstoque - quantVendida));
}
else
{
    Console.WriteLine("A quantidade vendida é maior que a quantidade em estoque");
}