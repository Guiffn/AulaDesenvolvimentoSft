//Testar as APIs
//Minimal APIs
//Rest Client - Extensão do VS code 
// - Postman 
// - Insomia 
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//Enpoints - Funcinalidade, ele interage com o usuário
//Request - Ela tem q ter uma URL o método/verbo HTTP
app.MapGet("/", () => "Hello World in C#");

app.MapGet("/retornarendereco", () =>
{
    dynamic endereco = new
    {
        rua = "Praça osorio",
        numero = 125
    };
    return endereco;
});

//Criar novas funcionalidades/ Endpoints para receber dados
// - Pelo URL da Requisição
// - Pelo corpo da requisição
// - Guardar as informações em um lista 

app.Run();
