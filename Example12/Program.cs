// Дан текст,нужно все пробелы заменить черточками,быуквы "к" заменить на большие "К",а большие "С" ЗАМЕНИТЬ НА МАЛЕНИЕ "С"

string text = "Я думаю, сказал князь"
            + "сказочно король жил Сам";
// чтобы обратиться к конкретному символу в строке используют:
// string s = "abcdefd"
//             0123456...
// s [3]-это буква с

string Replace(string text, char oldValue, char newValue)
{
string result = String.Empty; //это инициализация пустой строки
int length = text.Length;
for (int i = 0; i < length; i++)
{
    if(text [i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text [i]}";
}

return result;
}
string newText = Replace(text,' ','|');
Console.WriteLine(newText);