//five branches
//first branch - second_numb 
//second branch - third_numb
//third branch - week_day
//fourth branch - numb_squared

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * (-1);
}
number = number / 10;
number = number % 10;
 
Console.Write(number);
