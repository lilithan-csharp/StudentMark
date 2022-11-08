using IndividualMarkOfPerson;

namespace StudentResultTests
{
    public class StudentResultTest 
    {
        private readonly IStudentResult _service;
        public  StudentResultTest()
        {
            _service = new StudentResult();

        }
        [Fact]
        public void Test_ItemAreBeingAddedToList()
        {
            _service.AddMark(new StudentMark
            {
                Subject = "LO",
                Percentage = 80
            });
            _service.AddMark(new StudentMark
            {
                Subject = "LO",
                Percentage = 80
            });


            var avg = _service.OverallPercentage();
            Assert.Equal(80, avg);
        }

        [Fact]
        public void Test_FindPercentageAverage_Returns_OverAllPercentage()
        {
            _service.AddMark(new StudentMark
            {
                Subject = "LO",
                Percentage = 80
            });
            _service.AddMark(new StudentMark
            {
                Subject = "LS",
                Percentage = 70
            });

            var avg = _service.OverallPercentage();
            Assert.Equal(75, avg);

        }

        [Fact]
        public void Test_StudentFail_Return_False()
        {
            _service.AddMark(new StudentMark
            {
                Subject = "LO",
                Percentage = 50
            });
            _service.AddMark(new StudentMark
            {
                Subject = "LS",
                Percentage = 30
            });

            var avg = _service.OverallPercentage();
            Assert.Equal(40, avg);

            var fail = _service.PassOrFail();
            Assert.False(fail);

        }

        [Fact]
        public void Test_StudentPass_Return_True()
        {
            _service.AddMark(new StudentMark
            {
                Subject = "LO",
                Percentage = 80
            });
            _service.AddMark(new StudentMark
            {
                Subject = "LS",
                Percentage = 70
            });

            var avg = _service.OverallPercentage();
            Assert.Equal(75, avg);

            var pass = _service.PassOrFail();
            Assert.True(pass);

        }

        [Fact]
        public void Test_LowestPercentageMark_Return_LowestPercentage()
        {
            _service.AddMark(new StudentMark
            {
                Subject = "LO",
                Percentage = 80
            });
            _service.AddMark(new StudentMark
            {
                Subject = "LS",
                Percentage = 70
            });

            _service.AddMark(new StudentMark
            {
                Subject = "Maths",
                Percentage = 60
            });
            
            Assert.Equal("60", _service.WorstPercentage());
        }

        [Fact]
        public void Test_HighestPercentage_Return_BestSubject()
        {
            _service.AddMark(new StudentMark
            {
                Subject = "LO",
                Percentage = 80
            });
            _service.AddMark(new StudentMark
            {
                Subject = "LS",
                Percentage = 70
            });

            _service.AddMark(new StudentMark
            {
                Subject = "Maths",
                Percentage = 60
            });

            Assert.Equal("LO", _service.BestSubject());
        }
    }
}