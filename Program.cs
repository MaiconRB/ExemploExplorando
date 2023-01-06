 using ExemploExplorando.Models;
 using System.Globalization;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivosleitura.txt");

if(sucesso)
{
    Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
    

}

















//(int, string, string) tupla = (1, "Maicon", "Rodrigues");

//ValueTuple<int, string, string> outroexempllotupla = (1, "Maicon", "Rodrigues");

//var outroexempllotuplacreate = Tuple.Create(1, "Maicon", "Rodrigues");

// Console.WriteLine(tupla.Item1);
// Console.WriteLine(tupla.Item2);
// Console.WriteLine(tupla.Item3);



















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("MG", "Minas Gerais");
// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}");
// }
// Console.WriteLine("----------------------");
// estados.Remove("BA");
// estados["SP"] = "São Paulo - alterado";


// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor {item.Value}");
// }

// string chave = "BA";

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }else{
//     Console.WriteLine($"Valor não existe. É seguro colocar a: {chave}");
// }























// //PILHA
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach(int item in pilha)
//  {
//      Console.WriteLine(item);
//  }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(12);

// foreach(int item in pilha)
//  {
//      Console.WriteLine(item);
//  }



















//FILA
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

























// try {

// string[] linhas = File.ReadAllLines("Arquivos/arquivo_Texto.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// }catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu um erro genérico. {ex.Message}");
// }finally
// {

// Console.WriteLine("Chegou aqui.");

// }





















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 1524.50M;

// Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));


// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));




















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