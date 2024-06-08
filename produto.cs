namespace desafio;
public class produto
{
    public string NomeProduto {get; set;}
    public string Categoria{get; set;}
    public double Valor{get; set;}
    public int CodigoBarras{get; set;}


    public produto(string NomeProduto, string Categoria, double Valor, int CodigoBarras)
    {
        NomeProduto = nomeproduto;
        Categoria = categoria;
        Valor = valor;
        CodigoBarras = codigobarras;
    }
}