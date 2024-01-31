string str = "qqwewqq";
string answer = "Yes";
for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] != str[str.Length - i - 1])
    {
        answer = "No";
    }
}
Console.WriteLine(answer);