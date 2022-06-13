//five branches
//first branch - second_numb 
//second branch - third_numb
//third branch - week_day
//fourth branch - numb_squared

Console.Write("Input number week: ");
int number_week = Convert.ToInt32(Console.ReadLine());

if (number_week % 8 > 5)
{
    Console.Write(number_week + " - weekend");
}
else
{
    Console.Write(number_week + " - working day");
}