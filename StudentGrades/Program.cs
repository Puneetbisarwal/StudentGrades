using StudentGrades;

// Get input percentage
var gradeCalculator = new GradeCalculator();

Console.Write("Enter the percentage: ");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGradeByPercentage(percentage);

// Print the grade
Console.WriteLine($"Students Grade is: {grade}");