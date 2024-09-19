namespace MinimalApiProject.Models;

public class Produto
{

    //C# - Constructor 
    public Produto()
    {
        Id = Guid.NewGuid().ToString();
        CriadoEm = DateTime.Now;
    }
    // C# - Atributos/Propriedade/Características, get e set
    //Public deixa os gets e sets publico e esconde a variavel privada
    public string? Id { get; set; }
    public string? Nome { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }
    public DateTime CriadoEm { get; set; }


    //Java - atributos gets e set
    // private double preco;

    // public double getPreco()
    // {
    //     return this.preco;
    // }
    // public void setPreco(double preco)
    // {
    //     this.preco = preco;
    // }



}
