using ExemploFundamentos.Models;

//tipos de dados
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
quantidade = 10;
double altura = 1.80;
decimal preco = 1.80M; //se for passar o valor direto, tem que colocar M no final do valor
bool condicao = true;

DateTime dataFutura = DateTime.Now.AddDays(5); //adiciona dias
DateTime dataAtual = DateTime.Now; //data atual da maquina que você está usando
Console.WriteLine(dataFutura);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); //imprimi sem o horário

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);






/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Aline";
pessoa1.Idade = 32;
pessoa1.Apresentar();*/
 