using SUMMA.PruebaAgentes.Domain;

namespace TestAgentes.AgentesC
{
    public class AgenteCTest
    {
        [Fact]
        public void GetMedia_WorkCorrectly()
        {
            //Arrange
            var c = new AgenteC();
            var listTest = new List<double>() { 2, 2 };
            //Act
            var result = c.GetMedia(listTest);
            //Assert
            Assert.Equal(2.0, result, precision: 2);
        }


        [Fact]
        public void GetStaircase_ResultCorrectly()
        {
            //Arrange
            var c = new AgenteC();
            string waitingResult = "   ####   \r\n  ######  \r\n ######## \r\n##########\r\n ######## \r\n  ######  \r\n   ####   \r\n";
            //Act
            var result = c.GetStaircase(4);
            //Assert
            Assert.Equal(waitingResult, result);
        }
    }
}
