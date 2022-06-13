//five branches
//first branch - second_numb 
//second branch - third_numb
//third branch - week_day
//fourth branch - numb_squared

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (number < 100)
    {   
        Console.Write("the third digit is missing \n");
        Console.Write("Input a digit greater than 100: ");
        number = Convert.ToInt32(Console.ReadLine());
        continue;
    }
    else if (number > 100)
    {
        break;
    }
}

while(number > 1000)
{
    number = number / 10;
}

number = number % 10;
Console.Write(number);
