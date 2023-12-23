
namespace SUMMA.PruebaAgentes.Domain
{
    public class AgenteA : AgenteParents
    {
        public override double GetMedia(List<double> realList)
        {
            return realList.Average();
        }

        public override string GetStaircase(int number)
        {
            string result = "";
            for (int i = 1; i <= number; i++)
            {
                for (int j = number; j >= 1; j--)
                {
                    result += (j < i || j == i) ? "#" : " ";
                }
                result += "\r\n";
            }
            return result;
        }
    }
}
