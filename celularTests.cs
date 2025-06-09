using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CelularTests
{
    [TestMethod]
    public void TestarFazerChamada()
    {
        var celular = new ModeloA1();
        celular.FazerChamada("123456789");
        // Adicione asserções conforme necessário
    }

    // Outros testes...
}
