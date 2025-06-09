public abstract class Celular
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string SistemaOperacional { get; set; }

    public abstract void FazerChamada(string numero);
    public abstract void EnviarMensagem(string numero, string mensagem);
}

public class ModeloA1 : Celular
{
    public ModeloA1()
    {
        Marca = "Marca A";
        Modelo = "Modelo A1";
        SistemaOperacional = "Android";
    }

    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Chamada feita para {numero} usando {Modelo}.");
    }

    public override void EnviarMensagem(string numero, string mensagem)
    {
        Console.WriteLine($"Mensagem enviada para {numero}: {mensagem}");
    }
}
