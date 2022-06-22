namespace Example
{
    public static class Program
    {
        public static void Main()
        {
            List<int> list = new List<int> { 6, 1, 3, 7, 2, 7, 9, 8 };
            CocktailSort<int>(list);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static List<T> CocktailSort<T>(List<T> list) where T : IComparable
        {
            T var_buff;
            int index_buff = 0;
            int left = 0;
            int right = list.Count - 1;
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