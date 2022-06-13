//five branches
//first branch - second_numb 
//second branch - third_numb
//third branch - week_day
//fourth branch - numb_squared

Console.Write("Input number first: ");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number second: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 * num_1 == num_2 || num_2 * num_2 == num_1)
{
    if (num_1 < num_2)
    {
    Console.Write("The number "+ num_2 +" is the square of the number "+ num_1);
    }
    else if (num_2 < num_1)
    {
    Console.Write("The number "+ num_1 +" is the square of the number "+ num_2);
    }
}
else
{
    Console.Write("the number is not a square of another number");
}