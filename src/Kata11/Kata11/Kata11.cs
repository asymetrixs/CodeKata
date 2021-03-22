using System.Linq;

namespace CodeKata.Kata11
{
    public class Kata11
    {
        public static int[] AddAndSort(int[] sortedList, int? number)
        {
            if(number is not null)
            {
                var tmp = sortedList.ToList();

                bool added = false;
                for (int i = 0; i < sortedList.Length; i++)
                {
                    if(sortedList[i] > number)
                    {
                        tmp.Insert(i, number.Value);
                        added = true;
                    }
                }

                if(!added)
                {
                    tmp = tmp.Append(number.Value).ToList();
                }

                sortedList = tmp.ToArray();
            }

            return sortedList;
        }
    }
}
