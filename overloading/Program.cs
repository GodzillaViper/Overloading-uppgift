internal class Program
{
    // Assigment 1
    static int absolute(int num) {
        return num < 0 ? -num : num;
    }

    static double absolute(double num) {
        return num < 0 ? -num : num;
    }

    // Assigment 2
    static double calcArea(double radius) {
        return radius * radius * Math.PI;
    } 

    static double calcArea(double baseLength, double height) {
        return baseLength * height * 0.5;
    } 

    // Assigment 3
    static int add(int a, int b) {
        return a + b;
    }

    static double add(double a, double b) {
        return a + b;
    }
    
    static string add(string a, string b) {
        return a + b;
    }
    
    static string add(char a, char b) {
        return a.ToString() + b.ToString();
    }


    private static void Main(string[] args)
    {   
        // Assigment1();
        // Assigment2();
        Assigment3();
    }

    static void Assigment1() {
        Console.WriteLine($"Absolute value of -5 is {absolute(-5)}");
        Console.WriteLine($"Absolute value of -5.5 is {absolute(-5.5)}");
    }

    static void Assigment2() {
        while (true) {
            Console.Write("Select a shape to calculate its area (C: Circle, T: Triangle): ");
            string? shape = Console.ReadLine();

            switch (shape?.ToUpper()) {
                case "C":
                    Console.WriteLine("Enter a radius of a circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"The area is {calcArea(radius)}");
                    break;

                case "T":
                    Console.WriteLine("Enter base of a triangle: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter height of a triangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"The area is {calcArea(baseLength, height)}");
                    break;
                
                default: 
                    Console.WriteLine("Invalid command");
                    break;
            }

            Console.WriteLine("Do you want to calculate area of another shape (Y / N): ");
            string? action = Console.ReadLine();

            if (action?.ToUpper() == "Y") {
                continue;
            } else if (action?.ToUpper() == "N") {
                break;
            }
        }
    }

    static void Assigment3() {
        Console.WriteLine(add(1, 2));
        Console.WriteLine(add(1.5, 2.5));
        Console.WriteLine(add("hello", "world"));
        Console.WriteLine(add('a', 'b'));
    }
}