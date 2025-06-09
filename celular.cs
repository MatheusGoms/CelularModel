public abstract class Celular
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string SistemaOperacional { get; set; }

    public abstract void FazerChamada(string numero);
    public abstract void EnviarMensagem(string numero, string mensagem);
}
