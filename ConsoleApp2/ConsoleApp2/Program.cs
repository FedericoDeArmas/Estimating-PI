const int totalPoints = 10_000_000;
int insideCircle = 0;
Random rng = new();

for (int i = 0; i < totalPoints; i++)
{
    double x = rng.NextDouble();
    double y = rng.NextDouble();

    if (x * x + y * y <= 1.0)
        insideCircle++;
}

double piEstimate = (double)insideCircle / totalPoints * 4;
Console.WriteLine($"Monte Carlo π estimation: {piEstimate:F10}");