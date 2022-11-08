using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualMarkOfPerson
{
    public class StudentResult : IStudentResult
    {
        private List<IStudentMark> marksLists = new List<IStudentMark>() { };
        public void AddMark(IStudentMark result)
        {
           marksLists.Add(result);   
        }
       public decimal OverallPercentage()
       {
            decimal total = TotalSum();
            decimal averagePercentage = total / marksLists.Count;
            return averagePercentage;
        }

       public Boolean PassOrFail()
       {
           var studentAverage = OverallPercentage();
            if ( studentAverage >= 60)
            {
                return true;
            }
            return false;
       }

       public  string WorstPercentage()
       {  
            var lowestValue = 100m;
                      
            for (int i = 0; i < marksLists.Count; i++)
            {
                var currentValue = marksLists[i].Percentage;
            if (currentValue < lowestValue)
                {
                    lowestValue = currentValue;
                }
            }
            return lowestValue.ToString();
       }

       public  string BestSubject()
       {
            var highestValue = 0m;
            var bestSubject = "";
            for( int i = 0; i < marksLists.Count; i++)
            {
               if (marksLists[i].Percentage > highestValue)
               {
                    highestValue = marksLists[i].Percentage;
                    bestSubject = marksLists[i].Subject;
               }
            }
            return bestSubject.ToString();
       }
       private decimal TotalSum()
       {
            decimal total = 0;
            for (int i = 0; i < marksLists.Count; i++)
            {
                total += marksLists[i].Percentage;
            }
            return total;
       }
    }
}
