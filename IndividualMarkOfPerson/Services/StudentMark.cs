﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IndividualMarkOfPerson
{
    public class StudentMark : IStudentMark
    {
    public string Subject { get; set; }
    public  decimal Percentage { get; set; }
    }
}
