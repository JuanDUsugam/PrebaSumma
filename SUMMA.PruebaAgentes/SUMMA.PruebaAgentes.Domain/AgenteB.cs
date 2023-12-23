namespace SUMMA.PruebaAgentes.Domain
{
    public class AgenteB : AgenteParents
    {
        public override double GetMedia(List<double> realList)
        {
            return realList.Average(x => 1 / x);
        }

        public override string GetStaircase(int number)
        {
            string result = "";
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    result += (j > i || j == i) ? "#" : " ";
                }
                result += "\r\n";
            }
            return result;
        }
    }
}
