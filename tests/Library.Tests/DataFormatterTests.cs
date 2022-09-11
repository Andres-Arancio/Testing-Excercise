namespace Library.Tests;
using TestDateFormat;


[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
  
    /*
    <summary>
    El codigo corre correctamente
    </summary>
    <value>date = string valida</value>
    <value>result = string en el formato correcto</value>
    */
    [Test]
    public void DataFormatterTestCorrect()
    {
        string date = "27/12/1997";
        string expectedresult = "1997-12-27";
        Assert.AreEqual(DateFormatter.ChangeFormat(date), expectedresult);
    }
    
    /*
    <summary>
    A falta de una excepcion, idealmente si el formato es incorrecto, el resultado va a ser "ERROR"
    </summary>
    <value>date = string invalida que coloquialmente representa una fecha</value>
    */
    [Test]
    public void DataFormatterTestIncorrect()
    {
        string date = "Dec-27-1997";
        string expectedresult = "ERROR";
        Assert.AreEqual(expectedresult, DateFormatter.ChangeFormat(date));
    }
    
    /*
    <summary>
    A falta de una excepcion, idealmente si la fecha es null, el resultado va a ser "ERROR"
    </summary>
    <value>date = string vacia</value>
    */
    [Test]
    public void DataFormatterTestBlank()
    {
        string date = "";
        string expectedresult = "ERROR";
        Assert.AreEqual(expectedresult, DateFormatter.ChangeFormat(date));
    }
}