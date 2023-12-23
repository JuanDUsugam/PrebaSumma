using SUMMA.PruebaAgentes.Domain;

namespace TestAgentes.AgentesB
{
    public class AgenteBTest
    {
        [Fact]
        public void GetMedia_WorkCorrectly()
        {
            //Arrange
            var b = new AgenteB();
            var listTest = new List<double>() { 3.5, 4.8, 7, 9 };
            //Act
            var result = b.GetMedia(listTest);
            //Assert
            Assert.Equal(0.19, result, precision: 2);
        }


        [Fact]
        public void GetStaircase_ResultCorrectly()
        {
            //Arrange
            var b = new AgenteB();
            string waitingResult = "####\r\n ###\r\n  ##\r\n   #\r\n";
            //Act
            var result = b.GetStaircase(4);
            //Assert
            Assert.Equal(waitingResult, result);
        }
    }
}
