using System.Threading;
Console.Title = "Bildschirmschoner V1.0 © Semir Sljiivic";
Console.SetWindowSize(80, 30);
Console.SetBufferSize(80, 30);
Console.CursorVisible = false;
int x = 0, y = 0, xM = 1, yM = 1;

while (true)
{
    Console.SetCursorPosition(x, y);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("0");
    Thread.Sleep(10);
    Console.ForegroundColor = ConsoleColor.Black;
    Console.SetCursorPosition(x, y);
    Console.Write(" ");

    if (y == Console.WindowHeight - 1) { yM = -1; }
    if (y == 0) { yM = 1; }
    if (x == Console.WindowWidth - 1) { xM = -1; }
    if (x == 0) { xM = 1; }
    x = x + xM;
    y = y + yM;

}