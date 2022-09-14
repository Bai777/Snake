
int x = 1;
int y = 3;
char symbol = '*';

Draw(x, y, symbol);
Console.ReadLine();

void Draw(int x, int y, char symbol)
{
    Console.SetCursorPosition(x, y);
    Console.Write(symbol);
}
