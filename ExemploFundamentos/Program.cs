using ExemploFundamentos.Models;

/*operadores de atribuição
int a = 10;
int b = 20;

int c = a + b;

c += 5; //é o mesmo que c = c + 5;

Console.WriteLine(c); */
//-----------------------------------------------


//cast - Casting - conversão com convert aceita valor null, conversão com Parse não aceita null
/*int a = Convert.ToInt32("5"); //converter string em int
 Console.WriteLine(a);*/

/* Converter string para int
int inteiro = 5;
string a = inteiro.ToString();

Console.WriteLine(a);*/
//-------------------------------------------------
/*tipos de dados
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
Console.WriteLine("Valor da variável condicao: " + condicao);*/


//-------------------------------------------------
/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Aline";
pessoa1.Idade = 32;
pessoa1.Apresentar();*/
 