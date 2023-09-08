//Number 1
static double CALC_PI(double x0,  double y0, double r0, double ExpNmb)
{
    double xmin = x0 - r0;
    double xmax = x0 + r0;
    double ymin = y0 - r0;
    double ymax = y0 + r0;

    int m = 0;
    Random random = new Random();
    for (int i = 0; i < ExpNmb; i++)
    {
        double p = random.NextDouble();
        double x = (xmax - xmin) * p + xmin;

        p = random.NextDouble();
        double y = (ymax - ymin) * p + ymin;

        if (Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2) < Math.Pow(r0, 2))
            m++;
    }
    double S = (Convert.ToDouble(m) / ExpNmb) * 4;
    return S;
}

//Number 2
//1 (ExpNum = 10^4)
double x = CALC_PI(1, 2, 5, 10000);
Console.WriteLine($"CALC_PI(x0, y0, r0, ExpNmb) = {x}");

//2 SERIA_1
List<double> SERIA_1 = new() { x };
for (double i = Math.Pow(10, 5); i <= Math.Pow(10, 8); i *= 10)
{
    SERIA_1.Add(CALC_PI(1, 2, 5, i));
}

Console.WriteLine("\nSERIA_1:");
foreach (var i in SERIA_1)
{
    Console.WriteLine(i);
}

//3 SERIA_2, SERIA_3, SERIA_4, SERIA_5
List<double> SERIA_2 = new();
for (double i = Math.Pow(10, 4); i <= Math.Pow(10, 8); i *= 10)
{
    SERIA_2.Add(CALC_PI(1, 2, 5, i));
}

Console.WriteLine("\nSERIA_2:");
foreach (var i in SERIA_2)
{
    Console.WriteLine(i);
}

// SERIA_3
List<double> SERIA_3 = new();
for (double i = Math.Pow(10, 4); i <= Math.Pow(10, 8); i *= 10)
{
    SERIA_3.Add(CALC_PI(1, 2, 5, i));
}

Console.WriteLine("\nSERIA_3:");
foreach (var i in SERIA_3)
{
    Console.WriteLine(i);
}

// SERIA_4
List<double> SERIA_4 = new();
for (double i = Math.Pow(10, 4); i <= Math.Pow(10, 8); i *= 10)
{
    SERIA_4.Add(CALC_PI(1, 2, 5, i));
}

Console.WriteLine("\nSERIA_4:");
foreach (var i in SERIA_4)
{
    Console.WriteLine(i);
}

// SERIA_5
List<double> SERIA_5 = new();
for (double i = Math.Pow(10, 4); i <= Math.Pow(10, 8); i *= 10)
{
    SERIA_5.Add(CALC_PI(1, 2, 5, i));
}

Console.WriteLine("\nSERIA_5:");
foreach (var i in SERIA_5)
{
    Console.WriteLine(i);
}

//Number3
// Eps1
List<double> Eps1 = new();
for (int i = 0; i < SERIA_1.Count; i++)
{
    Eps1.Add(Math.Abs((SERIA_1[i] - Math.PI) / Math.PI));
}

Console.WriteLine("\nEps1:");
foreach (var a in Eps1)
{
    Console.WriteLine(a);
}

// Eps2
List<double> Eps2 = new();
for (int i = 0; i < SERIA_2.Count; i++)
{
    Eps2.Add(Math.Abs((SERIA_2[i] - Math.PI) / Math.PI));
}

Console.WriteLine("\nEps2:");
foreach (var a in Eps2)
{
    Console.WriteLine(a);
}

// Eps3
List<double> Eps3 = new();
for (int i = 0; i < SERIA_3.Count; i++)
{
    Eps3.Add(Math.Abs((SERIA_3[i] - Math.PI) / Math.PI));
}

Console.WriteLine("\nEps3:");
foreach (var a in Eps3)
{
    Console.WriteLine(a);
}

// Eps4
List<double> Eps4 = new();
for (int i = 0; i < SERIA_4.Count; i++)
{
    Eps4.Add(Math.Abs((SERIA_4[i] - Math.PI) / Math.PI));
}

Console.WriteLine("\nEps4:");
foreach (var a in Eps4)
{
    Console.WriteLine(a);
}

// Eps5
List<double> Eps5 = new();
for (int i = 0; i < SERIA_5.Count; i++)
{
    Eps5.Add(Math.Abs((SERIA_5[i] - Math.PI) / Math.PI));
}

Console.WriteLine("\nEps5:");
foreach (var a in Eps5)
{
    Console.WriteLine(a);
}

// S_e4
double S_e4 = (SERIA_1[0] + SERIA_2[0] + SERIA_3[0] + SERIA_4[0] + SERIA_5[0]) / 5;
Console.WriteLine($"\nS_e4 = {S_e4}");
double Eps_S_e4 = Math.Abs((S_e4 - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e4 = {Eps_S_e4}");

// S_e5
double S_e5 = (SERIA_1[1] + SERIA_2[1] + SERIA_3[1] + SERIA_4[1] + SERIA_5[1]) / 5;
Console.WriteLine($"\nS_e5 = {S_e5}");
double Eps_S_e5 = Math.Abs((S_e5 - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e5 = {Eps_S_e5}");

// S_e6
double S_e6 = (SERIA_1[2] + SERIA_2[2] + SERIA_3[2] + SERIA_4[2] + SERIA_5[2]) / 5;
Console.WriteLine($"\nS_e6 = {S_e6}");
double Eps_S_e6 = Math.Abs((S_e6 - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e6 = {Eps_S_e6}");

// S_e7
double S_e7 = (SERIA_1[3] + SERIA_2[3] + SERIA_3[3] + SERIA_4[3] + SERIA_5[3]) / 5;
Console.WriteLine($"\nS_e7 = {S_e7}");
double Eps_S_e7 = Math.Abs((S_e7 - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e7 = {Eps_S_e7}");

// S_e8
double S_e8 = (SERIA_1[4] + SERIA_2[4] + SERIA_3[4] + SERIA_4[4] + SERIA_5[4]) / 5;
Console.WriteLine($"\nS_e8 = {S_e8}");
double Eps_S_e8 = Math.Abs((S_e8 - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e8 = {Eps_S_e8}");

//Number 4
static double Func(double x)
{
    return Math.Pow(x, 3) + 1;
}

//1 Function CALC_INTEGER
static  double CALC_INTEGRAL(double a, double b, double ExpNmb)
{
    double xmin = a;
    double xmax = b;
    double ymin = 0;
    double ymax = Func(b);
    Random random = new Random();
    int m = 0;
    for (int i = 0; i < ExpNmb; i++)
    {
        double p = random.NextDouble();
        double x = (xmax - xmin) * p + xmin;

        p = random.NextDouble();
        double y = (ymax - ymin) * p + ymin;

        if (Func(x) > y)
            m++;
    }

    double S = (Convert.ToDouble(m) / ExpNmb) * (b - a) * Func(b);
    return S;
}

//INTEGRAL_SERIA_1, INTEGRAL_SERIA_2, INTEGRAL_SERIA_3
List<double> INTEGRAL_SERIA_1 = new();
for (double i = Math.Pow(10, 4); i <= Math.Pow(10, 7); i *= 10)
{
    INTEGRAL_SERIA_1.Add(CALC_INTEGRAL(0, 2, i));
}

Console.WriteLine("\nINTEGRAL_SERIA_1:");
foreach (var i in INTEGRAL_SERIA_1)
{
    Console.WriteLine(i);
}

//INTEGRAL_SERIA_2
List<double> INTEGRAL_SERIA_2 = new();
for (double i = Math.Pow(10, 4); i <= Math.Pow(10, 7); i *= 10)
{
    INTEGRAL_SERIA_2.Add(CALC_INTEGRAL(0, 2, i));
}

Console.WriteLine("\nINTEGRAL_SERIA_2:");
foreach (var i in INTEGRAL_SERIA_2)
{
    Console.WriteLine(i);
}

//INTEGRAL_SERIA_3
List<double> INTEGRAL_SERIA_3 = new();
for (double i = Math.Pow(10, 4); i <= Math.Pow(10, 7); i *= 10)
{
    INTEGRAL_SERIA_3.Add(CALC_INTEGRAL(0, 2, i));
}

Console.WriteLine("\nINTEGRAL_SERIA_3:");
foreach (var i in INTEGRAL_SERIA_3)
{
    Console.WriteLine(i);
}

// Eps1_INTEGRAL
List<double> Eps1_INTEGRAL = new();
for (int i = 0; i < INTEGRAL_SERIA_1.Count; i++)
{
    Eps1_INTEGRAL.Add(Math.Abs((INTEGRAL_SERIA_1[i] - Math.PI) / Math.PI));
}

Console.WriteLine("\nEps1_INTEGRAL:");
foreach (var a in Eps1_INTEGRAL)
{
    Console.WriteLine(a);
}

// Eps2_INTEGRAL
List<double> Eps2_INTEGRAL = new();
for (int i = 0; i < INTEGRAL_SERIA_2.Count; i++)
{
    Eps2_INTEGRAL.Add(Math.Abs((INTEGRAL_SERIA_2[i] - Math.PI) / Math.PI));
}

Console.WriteLine("\nEps2_INTEGRAL:");
foreach (var a in Eps2_INTEGRAL)
{
    Console.WriteLine(a);
}

// Eps3_INTEGRAL
List<double> Eps3_INTEGRAL = new();
for (int i = 0; i < INTEGRAL_SERIA_3.Count; i++)
{
    Eps3_INTEGRAL.Add(Math.Abs((INTEGRAL_SERIA_3[i] - Math.PI) / Math.PI));
}

Console.WriteLine("\nEps3_INTEGRAL:");
foreach (var a in Eps3_INTEGRAL)
{
    Console.WriteLine(a);
}

// S_e4_INTEGRAL
double S_e4_INTEGRAL = (INTEGRAL_SERIA_1[0] + INTEGRAL_SERIA_2[0] + INTEGRAL_SERIA_3[0]) / 3;
Console.WriteLine($"\nS_e4_INTEGRAL = {S_e4_INTEGRAL}");
double Eps_S_e4_INTEGRAL = Math.Abs((S_e4_INTEGRAL - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e4_INTEGRAL = {Eps_S_e4_INTEGRAL}");

// S_e5_INTEGRAL
double S_e5_INTEGRAL = (INTEGRAL_SERIA_1[1] + INTEGRAL_SERIA_2[1] + INTEGRAL_SERIA_3[1]) / 3;
Console.WriteLine($"\nS_e5_INTEGRAL = {S_e5_INTEGRAL}");
double Eps_S_e5_INTEGRAL = Math.Abs((S_e5_INTEGRAL - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e5_INTEGRAL = {Eps_S_e5_INTEGRAL}");

// S_e6_INTEGRAL
double S_e6_INTEGRAL = (INTEGRAL_SERIA_1[2] + INTEGRAL_SERIA_2[2] + INTEGRAL_SERIA_3[2]) / 3;
Console.WriteLine($"\nS_e6_INTEGRAL = {S_e6_INTEGRAL}");
double Eps_S_e6_INTEGRAL = Math.Abs((S_e6_INTEGRAL - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e6_INTEGRAL = {Eps_S_e6_INTEGRAL}");

// S_e7_INTEGRAL
double S_e7_INTEGRAL = (INTEGRAL_SERIA_1[3] + INTEGRAL_SERIA_2[3] + INTEGRAL_SERIA_3[3]) / 3;
Console.WriteLine($"\nS_e7_INTEGRAL = {S_e7_INTEGRAL}");
double Eps_S_e7_INTEGRAL = Math.Abs((S_e7_INTEGRAL - Math.PI) / Math.PI);
Console.WriteLine($"Eps_S_e7_INTEGRAL = {Eps_S_e7_INTEGRAL}");