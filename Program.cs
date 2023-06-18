
int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(DniNedely(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string DniNedely(int o)
{
    if (o > 0 && o < 8)
    {
        if (o == 7 || o == 6)
        {
            Console.Write(+ o +  "---> да");
        }
        else
        {
            Console.Write(+ o + "---> нет");
        }
    }
    else
    {
        Console.Write("Ведите число от 1 до 7 повторно");
    }
    return "";
}