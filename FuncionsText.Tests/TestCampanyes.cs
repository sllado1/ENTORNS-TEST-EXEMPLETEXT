using FluentAssertions;

namespace FuncionsText.Tests;

public class TestCampanyes
{
    // Test de la funció NumCampanyes
    // Verifica que el nombre de campanyes és correcte

    [Fact]
    public void TestNumCampanyesCorrecte()
    { 
        Campanyes campanyes = new Campanyes();
        int ncampanyes = 1;
        
        int resncampanyes = campanyes.NumCampanyes(ncampanyes);
        Assert.Equal(1, resncampanyes);  // Comprovem que el nombre de campanyes és correcte

    }

    [Theory]
    [InlineData(-1,-1)]
    [InlineData(10001,-1)]
    [InlineData(0,0)]
    [InlineData(10000,10000)]
    [InlineData(1,1)]
    [InlineData(9999,9999)]
    public void TestBoundaryNumCampanyes(int ncampanyes, int resultat)
    {
        // Boundary test
        // És una tècnica que es fa servir per provar el comportament d’un sistema en els seus límits o fronteres. 
        // Sabem que el número de campanyes acceptats són valors entre 0 i 10000
        // per tant, comprovarem:
        // -1: el nombre de campanyes és incorrecte (limit -1)
        // 10001: el nombre de campanyes és incorrecte (limit +1)
        // 0: el nombre de campanyes és correcte (limit)
        // 10000: el nombre de campanyes és correcte (limit)
        // 1: el nombre de campanyes és correcte (limit+1)
        // 9999: el nombre de campanyes és correcte (limit-1)
        // Si passa tots aquests testos estem segurs que la funció és correcte
        Campanyes campanyes = new Campanyes();
        ncampanyes = campanyes.NumCampanyes(ncampanyes);
        Assert.Equal(resultat, ncampanyes);  
        //Utilitzant fluent assertions
        resultat.Should().Be(ncampanyes);
    }

    // Test de la funció NumAnellamentsCampanya
    [Fact]
    public void TestNumAnellamentsCampanyaCorrecte()
    {
        Campanyes campanyes = new Campanyes();
        string valorsCampanya = "10 5 0";
        int resultat = campanyes.NumAnellamentsCampanya(valorsCampanya);
        Assert.Equal(-1, resultat);  // Comprovem que la funció detecta l'error d'entrada. Cas extrem
    }

    [Theory]
    [InlineData(0,1,-3)] //Anelemants > capturats
    [InlineData(10001,1,10000)]  //Aquest test falla perquè no pot haver-hi una entrada de 10001 (El màxim es 10000)
    [InlineData(1,10001,-2)] //Anellaments incorrectes
    [InlineData(1,1,0)]
    [InlineData(10000,10000,0)]
    [InlineData(9999,9999,0)]
    public void TestBoundaryNumAnellamentsCampanya(int numCapturats, int numJaAnellats, int resultat)
    {
        //Inicialització inicial
        Campanyes campanyes = new Campanyes();
        string valorsCampanya = $"{numCapturats} {numJaAnellats}";
        //Execució de la funció
        int res = campanyes.NumAnellamentsCampanya(valorsCampanya);
       
        //Comprovació del resultat
        Assert.Equal(resultat, res);  
        //Utilitzant fluent assertions
        resultat.Should().Be(res);
    }
}