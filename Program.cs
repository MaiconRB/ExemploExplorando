using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 1524.50M;

Console.WriteLine($"{valorMonetario:C}");

Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));


DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));




















//Pessoa p1 = new Pessoa(nome: "Maicon",sobrenome: "Rodrigues");
//Pessoa p2 = new Pessoa(nome: "João",sobrenome: "Rodrigues");


//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Ingles";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();






































//p1.Nome = "Maicon";
//p1.Sobrenome = "Rodrigues";
//p1.Idade = 24;
//p1.Apresentar();
//p2.Nome = "João";
//p2.Sobrenome = "Rodrigues";