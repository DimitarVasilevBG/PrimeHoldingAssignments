using System;
using System.Collections.Generic;
using System.Linq;

namespace Median_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            var scores = new List<int>() {100, 20, 50, 70, 45};
            try
            {
                var result = GetMedianScoreList(scores);
                Console.WriteLine('[' + String.Join(",", result) + ']');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static List<int> GetMedianScoreList(List<int> scores)
        {
            //Add the first element to the result, if it's empty return 0
            var result = new List<int> {scores.FirstOrDefault(x => true)};

            for (int i = 2; i <= scores.Count; i++)
            {
                //Creates a list from input which takes i elements and sorts them
                var subScores = scores.Take(i).OrderBy(x => x).ToList();
                int median;
                //If count is even, return middle elements summed and divided by 2 rounded to nearest integer
                if (subScores.Count % 2 == 0)
                {
                    //Get the middle left and right integer indexes
                    var left = (subScores.Count / 2) - 1;
                    var right = (subScores.Count / 2);
                    //Calculates the median
                    median = (int) Math.Round((decimal) (subScores[left] + subScores[right]) / 2);
                }
                //If count is odd get the middle element of the sorted list
                else
                {
                    //Gets the middle integer
                    var middle = subScores.Count / 2;
                    median = subScores[middle];
                }

                //Add the median to the result list
                result.Add(median);
            }

            return result;
        }
    }
}