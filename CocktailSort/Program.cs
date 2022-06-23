namespace SortingApp
{
    public static class Cocktail
    {
        public static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Input some numbers separated by whitespace character");
                return;
            }

            List<double> input = new List<double>(args.Length);
            try
            {
                foreach (string s in args)
                {
                    input.Add(double.Parse(s));
                }
            } catch 
            {
                Console.WriteLine("Invalid input");
            }

            Sort(input);
            Console.Write("CocktailSort: ");
            foreach(double d in input)
            {
                Console.Write(d.ToString() + ' ');
            }
            Console.WriteLine();
        }

        public static List<T> Sort<T>(List<T> list) where T : IComparable
        {
            T var_buff;
            int index_buff = 0;
            int left = 0;
            // int right = list.Count - 1;
            int right = list.Count - 2;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                    {
                        var_buff = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = var_buff;
                        index_buff = i;
                    }
                }
                right = index_buff;
                if (left >= right) break;
                for (int i = right; i > left; i--)
                {
                    if (list[i - 1].CompareTo(list[i]) > 0)
                    {
                        var_buff = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = var_buff;
                        index_buff = i;
                    }
                }
                left = index_buff;
            }
            return list;
        }
    }
}