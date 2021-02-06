using NUnit.Framework;

namespace NUnitTestNumeroLiteral
{
    public class TestNumeroLiteal
    {
        public object NumeroLiteralController { get; private set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConversionesGet()
        {
            //Arrange=preparacion

            string num1 = "8";
            string num2 = "5";
            string num3 = "10.2";
            string num4 = "-3";
            string num5 = "1234567.89";
            string esperado1 = "CERO";
            string esperado2 = "CINCO";
            string esperado3 = "DIEZ PUNTO DOS";
            string esperado4 = "MENOS TRES";
            string esperado5 = "UN MILLON DOCIENTOS TREINTA Y CUATRO MIL QUINIENTOS SESENTA Y SIETE PUTO OCENTA Y NUEVE";

            NumeroLiteralController conv = new NumeroLiteralController();

            //Act=ejecucion

            string resultado = conv.ConversionesGet(num1, num2, num3, num4, num5);

            //Assert=verificacion

            Assert.AreEqual(esperado5, resultado);
        }
        [Test]
        public void TestConversionesPost()
        {
            //Arrange=preparacion

            string num1 = "8";
            string num2 = "5";
            string num3 = "10.2";
            string num4 = "-3";
            string num5 = "1234567.89";
            string esperado1 = "CERO";
            string esperado2 = "CINCO";
            string esperado3 = "DIEZ PUNTO DOS";
            string esperado4 = "MENOS TRES";
            string esperado5 = "UN MILLON DOCIENTOS TREINTA Y CUATRO MIL QUINIENTOS SESENTA Y SIETE PUTO OCENTA Y NUEVE";

            NumeroLiteralController conv = new NumeroLiteralController();

            //Act=ejecucion

            string resultado = conv.ConversionesPost(num1, num2, num3, num4, num5);

            //Assert=verificacion

            Assert.AreEqual(esperado5, resultado);

        }

    }
}
