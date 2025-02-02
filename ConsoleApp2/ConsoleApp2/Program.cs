const int PRECISION = 10000;

double result = 0;
double distanceBetweenPoints = 1.0 / PRECISION;
(double x, double y) currentPoint = (0, 1);
while (currentPoint.x + distanceBetweenPoints <= 1)
{
    double nextX = currentPoint.x + distanceBetweenPoints;
    double nextY = Math.Sqrt(1 - Math.Pow(nextX, 2));
    result += Math.Sqrt(Math.Pow(currentPoint.x - nextX, 2) + Math.Pow(currentPoint.y - nextY, 2));
    currentPoint = (nextX, nextY);
    Console.WriteLine($"Current π estimation: {result * 2}");
}
