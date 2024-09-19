//Testar as APIs
//Minimal APIs
//Rest Client - Extensão do VS code 
// - Postman 
// - Insomia 
using MinimalApiProject.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
// LISTA DE PRODUTOS
List<Produto> produtos = new List<Produto>
{
new Produto { Nome = "Camiseta Polo", Preco = 59.90, Quantidade = 10 },
new Produto { Nome = "Calça Jeans", Preco = 129.90, Quantidade = 20 },
new Produto { Nome = "Tênis Esportivo", Preco = 199.90, Quantidade = 15 },
new Produto { Nome = "Jaqueta de Couro", Preco = 349.90, Quantidade = 5 },
new Produto { Nome = "Óculos de Sol", Preco = 89.90, Quantidade = 25 },
new Produto { Nome = "Relógio Digital", Preco = 149.90, Quantidade = 12 },
new Produto { Nome = "Bolsa de Couro", Preco = 219.90, Quantidade = 8 },
new Produto { Nome = "Cinto de Couro", Preco = 39.90, Quantidade = 30 },
new Produto { Nome = "Chapéu Panamá", Preco = 79.90, Quantidade = 18 },
new Produto { Nome = "Camisa Social", Preco = 89.90, Quantidade = 22 }
};
// produtos.Add(new Produtos()){

//     Nome ="";
//     Preco= ;


// }

//Enpoints - Funcinalidade, ele interage com o usuário
//Request - Ela tem q ter uma URL o método/verbo HTTP
app.MapGet("/", () => "APi de Produtos!");

//Requisição via GET: http://localhost:5051/produto/listar 
app.MapGet("/produto/listar/{nome}", (string nome) =>
{
    Produto produto = new Produto();
    produto.Nome = nome;
    produtos.Add(produto);
    return produtos;

});
//Requisição via GET: http://localhost:5051/produto/cadastrar 
app.MapPost("/produto/cadastrar", () =>
{
    return produtos;

});




//Criar novas funcionalidades/ Endpoints para receber dados
// - Pelo URL da Requisição
// - Pelo corpo da requisição
// - Guardar as informações em um lista 

app.Run();
Produto produto = new Produto();
produto.Preco = 750128;
Console.WriteLine("Preço: " + produto.Preco);

