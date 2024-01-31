string GetStringFromCharMatrix(char[,] matrix)
{
    string str = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str = str + matrix[i, j];
        }
    }
    return str;
}



char[,] matrix = {
    {'q','w','e'},
    {'r','t','y'},
    {'a','s','d'}
};
string answer = GetStringFromCharMatrix(matrix);
Console.Write(answer);