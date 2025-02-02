# Estimating Pi Using Arc Length Approximation
This project started as a bet with a friend to see who could achieve a better π estimation using C# and some trigonometry with the minimum amount of iterations.

## 📌 Method Description
The main idea is to extrapolate the Riemann sum using lengths instead of areas between each subdivision, and keeping the following relation in mind:

![image](https://github.com/user-attachments/assets/03a4f029-058f-48cb-917b-9333bddda8a9)

The method used is based on the geometry of a circle with a radius of 1. In a unit circle centered at the origin, the equation of the circumference is:
x^2 + y^2 = 1


Since we want to calculate the length of a quarter-circle (starting from `(x, y) = (0,1)` and `θ = π/2`), we can divide this arc into small straight segments and sum their lengths. Since we know that the final lenght is 1*π/2, we multiply the final result by 2 to obtain an approximation of π.

## 🛠️ Arc Length Calculation
To approximate the arc length, the following steps are used:

1. Define a `PRECISION` value, which represents how many segments will be used to divide the arc.
2. Establish a fixed distance between consecutive points on the X-axis, calculated as `1/PRECISION`.
3. Start from the point `(0,1)` and, in a `while` loop, calculate the following values:
   - `nextX`: the new X coordinate incremented by `distanceBetweenPoints`.
   - `nextY`: the corresponding Y coordinate on the circumference, calculated as  `√(1 - x²)`
   - Compute the distance between the current and next points using the Euclidean distance formula:
     `l = √((x₂ - x₁)² + (y₂ - y₁)²)`
   - Update the accumulated sum of segment lengths.
4. Finally, multiply the result by 2 to obtain the approximation of π.

## 📜 Main Code
```csharp
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
