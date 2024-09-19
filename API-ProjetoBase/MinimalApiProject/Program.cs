using Microsoft.AspNetCore.Mvc;
using MinimalApiProject.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// LISTA DE PRODUTOS
List<Produto> produtos = new List<Produto>()
{
    new Produto { Nome = "Camiseta Polo", Preco = 59.90, Quantidade = 10 },
    new Produto { Nome = "Calça", Preco = 129.90, Quantidade = 20 },
    new Produto { Nome = "Tênis Esportivo", Preco = 199.90, Quantidade = 15 },
    new Produto { Nome = "Jaqueta de Couro", Preco = 349.90, Quantidade = 5 },
    new Produto { Nome = "Óculos de Sol", Preco = 89.90, Quantidade = 25 },
    new Produto { Nome = "Relógio Digital", Preco = 149.90, Quantidade = 12 },
    new Produto { Nome = "Bolsa de Couro", Preco = 219.90, Quantidade = 8 },
    new Produto { Nome = "Cinto de Couro", Preco = 39.90, Quantidade = 30 },
    new Produto { Nome = "Chapéu Panamá", Preco = 79.90, Quantidade = 18 },
    new Produto { Nome = "Camisa Social", Preco = 89.90, Quantidade = 22 }
};

// Enpoints
app.MapGet("/", () => "API de Produtos!");

// Listar produtos
app.MapGet("/produto/listar", () =>
{
    if (produtos.Count > 0)
    {
        return Results.Ok(produtos);
    }
    return Results.NotFound();
});

// Buscar produto pelo nome
app.MapGet("/produto/buscar/{nome}", ([FromRoute] string nome) =>
{
    foreach (Produto produtoCadastrado in produtos)
    {
        if (produtoCadastrado.Nome == nome)
        {
            return Results.Ok(produtoCadastrado);
        }
    }
    return Results.NotFound();
});

// Cadastrar produto
app.MapPost("/produto/cadastrar", ([FromBody] Produto produto) =>
{
    produtos.Add(produto);
    return Results.Created("", produto);
});
// Altera Produto
app.MapPost("/produto/altera/{produtoAlterado}", ([FromRoute] String nome, [FromBody] Produto produto) =>
{
    foreach (Produto produtoCadastrado in produtos)
    {
        if (produtoCadastrado.Nome == produtoAlterado)
        {
            Produto produtoAlterado = produtoCadastrado;
            return Results.Created("", produto);

        }
    }
    return Results.NotFound();
});


app.Run();


//Implementar todas as funcionalidades do CRUD
// - Remover porduto
// - Alterar produto 


