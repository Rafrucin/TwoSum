using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {

        //for (int i = 0; i < list.Count; i++)
        //{
        //    for (int j = i+1; j < list.Count; j++)
        //    {
        //        if (list[i]+list[j]==sum)
        //        {
        //            return  new Tuple<int, int>(i,j);
        //        }
        //    }
        //}

        HashSet<int> hs = new HashSet<int>();
        for (int i = 0; i < list.Count; i++)
        {
            var needed = sum - list[i];
            if (hs.Contains(needed))
            {
                return Tuple.Create(list.IndexOf(needed), i);
            }
            hs.Add(list[i]);
        }
        return null;





    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
            Console.ReadLine();
        }
    }
}