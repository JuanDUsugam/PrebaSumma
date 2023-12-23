namespace SUMMA.PruebaAgentes.Domain
{
    public class AgenteC : AgenteParents
    {
        public override double GetMedia(List<double> realList)
        {
            var sortList = realList.OrderBy(x => x).ToList();

            var countList = sortList.Count();
            if (countList % 2 == 0)
            {
                int indexHalf = countList / 2;
                int otherHalf = indexHalf - 1;
                return (sortList[indexHalf] + sortList[otherHalf]) / 2;
            }
            else
            {
                return sortList.Find((x) => sortList.IndexOf(x) == countList / 2);
            }

        }

        public override string GetStaircase(int number)
        {


            string result = string.Empty;
            int size = (number * 2) - 1;
            int sizeRow = number + ((number - 1) * 2);
            int spaces = ((number - 1) * 2);
            string caracterchain = new string('#', sizeRow);
            var listChar = new List<char>(caracterchain.ToCharArray());

            for (int i = 1; i <= size; i++)
            {
                result += string.Concat(CambiarExtremos(listChar, spaces / 2));
                listChar = new List<char>(caracterchain.ToCharArray());
                result += "\r\n";
                if (i < number)
                {
                    spaces -= 2;
                }
                if (i >= number)
                {
                    spaces += 2;
                }
            }


            return result;
        }

        private List<Char> CambiarExtremos(List<char> lista, int numeroDeCaracteres)
        {
            for (int i = 0; i < numeroDeCaracteres; i++)
            {
                lista[i] = ' ';
            }

            // Cambiar los últimos caracteres
            for (int i = lista.Count - numeroDeCaracteres; i < lista.Count; i++)
            {
                lista[i] = ' ';
            }
            return lista;
        }
    }
}
