namespace StudentGrades.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        //[Test]
        //public void GetGradeByPercentage_EqualTest()
        //{
        //    // Assign
        //    var percentage = 90;

        //    // Act
        //    var grade = _gradeCalculator.GetGradeByPercentage(percentage);

        //    // Assert
        //    Assert.AreEqual("A", grade);

        //}


        [TestCase(91)]
        [TestCase(93)]
        [TestCase(95)]
        [TestCase(97)]
        [TestCase(99)]
        
        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.AreEqual("A", grade);

        }

        [TestCase(-1)]
        [TestCase(990)]
        [TestCase(-980)]
        [TestCase(0)]
        [TestCase(100)]

        public void GetGradeByPercentage_NotEqualTest(int percentage)
        {


            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.AreNotEqual("A", grade);

        }
    }
}