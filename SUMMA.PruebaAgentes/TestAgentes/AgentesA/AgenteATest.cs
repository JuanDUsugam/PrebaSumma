using SUMMA.PruebaAgentes.Domain;

namespace TestAgentes.AgentesA
{
    public class AgenteATest
    {
        [Fact]
        public void GetMedia_WorkCorrectly()
        {
            //Arrange
            var a = new AgenteA();
            var listTest = new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0 };
            //Act
            var result = a.GetMedia(listTest);
            //Assert
            Assert.Equal(3.0, result, precision: 2);
        }

        
        [Fact]
        public void GetStaircase_ResultCorrectly()
        {
            //Arrange
            var a = new AgenteA();
            string waitingResult = "   #\r\n  ##\r\n ###\r\n####\r\n";
            //Act
            var result = a.GetStaircase(4);
            //Assert
            Assert.Equal(waitingResult, result);
        }
    }
}
