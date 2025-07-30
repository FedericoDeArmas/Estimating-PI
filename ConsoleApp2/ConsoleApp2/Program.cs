const int precision = 10_000;
double totalLength = 0;
double stepSize = 1.0 / precision;
double currentX = 0;
double currentY = 1;

for (int i = 0; i < precision; i++)
{
    double nextX = currentX + stepSize;
    double nextY = Math.Sqrt(1 - nextX * nextX);
    double dx = nextX - currentX;
    double dy = nextY - currentY;
    totalLength += Math.Sqrt(dx * dx + dy * dy);

    // Optional: Show progress every 1000 steps
    if (i % 1000 == 0)
    {
        Console.WriteLine($"Current π estimation: {totalLength * 2:F6}");
    }

    currentX = nextX;
    currentY = nextY;
}

Console.WriteLine($"\nFinal π estimation: {totalLength * 2:F10}");