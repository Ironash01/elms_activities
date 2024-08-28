using System;

class GreetingProgram {
    static string input_name;
    static int input_enrolledCourses;
    static double input_priceFavBook;
    public static void Main() {
        Console.WriteLine("Greeting Program");
        Console.WriteLine("================");
        Console.WriteLine(" ");
        Console.Write("Enter name: ");
        input_name = Console.ReadLine();
        Console.Write("Enter the number of your enrolled courses: ");
        input_enrolledCourses = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the price of your favorite book: ");
        input_priceFavBook = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("================INPUT PREVIEW================");
        Console.WriteLine("Name: " + input_name);
        Console.WriteLine("Enrolled Courses: " + input_enrolledCourses);
        Console.WriteLine("Price of Favorite Book: " + input_priceFavBook);

    }
}