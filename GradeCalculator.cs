// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your Exam Score:");
int examScore = Convert.ToInt32(Console.ReadLine());
if (examScore >= 90)
{
    Console.WriteLine("The Student will be awarded a grade A");
}
else if (examScore >= 80)
{
    Console.WriteLine("The Student will be awarded a grade B");
}
else if (examScore >= 70)
{
    Console.WriteLine("The Student will be awarded a grade C");
}
else if (examScore >= 60)
{
    Console.WriteLine("The Student will be awarded a grade D");
}
else
{
    Console.WriteLine("The Student will be awarded a grade F. He/She failed the course");
}


