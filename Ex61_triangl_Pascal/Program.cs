// Ex61: Вывести первые N строк треугольника Паскаля. 
//Сделать вывод в виде равнобедренного треугольника

void DrawText(string text, int left, int top)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine($"1 + {text} + 1");
}
Console.Write($"Введите степень для вывода треугольника Паскаля с коэффициентами соответствующeго бинома; n = ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    string[] strTrianglPascal = new string[n + 1];
    int length = strTrianglPascal.Length;
    strTrianglPascal[0] = KoeffBinom(1);
    strTrianglPascal[strTrianglPascal.Length - 1] = " 1";
    int j = 1;
    string KoeffBinom (string courrent, int posKoeff)
    {
        if (posKoeff ==  0 || posKoeff == strTrianglPascal.Length - 1) return "1";
        if (posKoeff < n / 2) return KoeffBino(courrent - 1, posKoeff)[posKoeff - 1] + KoeffBino(courrent - 1, posKoeff)[posKoeff + 1];
        
    }
    while (j < length)
    {
        if (j == 1 || j == strTrianglPascal.Length - 1) strTrianglPascal[j] =  $" {n} ";
        else strTrianglPascal[j] = posKoeff[strTrianglPascal, j];
        j++;
    }  
        int screenWidthPosition = (Console.WindowWidth - strTrianglPascal.Length) / 2;
        int screenHeigthPosition = Console.WindowHeigth / 2 + j;
        DrawText(
            text: strTrianglPascal,
            left: screenWidthPosition,
            top: screenHeigthPosition
            );
}  