using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualMarkOfPerson
{
    public interface IStudentResult
    {
        void AddMark(IStudentMark result);
        decimal OverallPercentage();
        Boolean PassOrFail();
        string WorstPercentage();
        string BestSubject();
    }
}
