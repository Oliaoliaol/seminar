//Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.
 
/* int  FindBiggerDigit(int num)
{
    int result;

    if (num < 10 || num>=100)
        return 0;
    else
    {
        int ed = num % 10;
        int dec =num/10;

        if(ed > dec)
            result = dec;
        else result =dec;
            
    }
    return result;
}

Console.Write("Input a two digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int biggerDigit = FindBiggerDigit(number);
Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");
*/

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.



/*int DeleteSecondNumber(int num)
{
    int result;
    int ed = num % 10;
    int sot = num /100;

    result = sot*10+ed;
    return result;
        
}
int number = new Random().Next(100, 999);

int twoBigitNumber = DeleteSecondNumber(number);
Console.WriteLine($"A three-digit number {number} without a second cipher {twoBigitNumber}");
*/









