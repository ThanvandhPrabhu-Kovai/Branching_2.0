using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_2
{
    class Program
    {
        static void Main(string[] args)
        {
            menuDrivenProgramToPerformSimpleCalculation();
            menuDrivenProgramToComputeGeometricalShape();
            displayNumberOfDaysInAMonth();
            displayNameOfInputMonth();
            displayDayName();
            displayWordForDigits();
            displayGradeAndItsEquivalent();
            getCustomerElectricityBill();
            calculateProfitAndLoss();
            Console.ReadLine();
        }

        //Menu-Driven Program to perform a simple calculation.-Switch Case
        static void menuDrivenProgramToPerformSimpleCalculation()
        {
            Console.Write("\n\nA menu driven program for a simple calculator : ");
            Console.Write("\n\n------------------");
            Console.Write("\n\nEnter the first integer : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nEnter the second integer : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nHere are the options : ");
            Console.Write("\n\n\t1-Addition\n\t2-Subtraction\n\t3-Multiplication\n\t4-Division\n\t5-Exit");
            Console.Write("\n\nInput your choice : ");
            int option = Convert.ToInt32(Console.ReadLine());
            void showOutput(String operation, int result) => Console.Write("\n\nThe {0} of {1} and {2} is : {3}", operation, num1, num2, result);
            switch (option)
            {
                case 1:
                    int sum = num1 + num2;
                    showOutput("Addition", sum);
                    break;
                case 2:
                    int difference = num1 - num2;
                    showOutput("Subtraction", difference);
                    break;
                case 3:
                    int product = num1 * num2;
                    showOutput("Multiplication", product);
                    break;
                case 4:
                    bool isNum2Is0 = num2 == 0;
                    if (isNum2Is0)
                    {
                        Console.Write("\n\nThe second integer is zero.");
                    }
                    else
                    {
                        int divisionResult = num1 / num2;
                        showOutput("Division", divisionResult);
                    }
                    break;
                default:
                    Console.Write("\n\nInput correct option");
                    break;
            }
        }

        //Menu-Driven Program to compute the area of the various geometrical shape
        static void menuDrivenProgramToComputeGeometricalShape()
        {
            double area = 0.0;
            Console.Write("\n\nA menu driven program to compute area of various geometrical shape : ");
            Console.Write("\n\n------------------");
            Console.Write("\n\n\tInput 1 for area of circle\n\tInput 2 for area of Rectangle\n\tInput 3 for area of Triangle");
            Console.Write("\n\nInput your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            void showOutput() => Console.Write("\n\nThe area is {0}", area);
            switch (choice)
            {
                case 1:
                    Console.Write("\n\nInput radius of the circle : ");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    area = (3.14 * radius * radius);
                    showOutput();
                    break;
                case 2:
                    Console.Write("\n\nInput length of the rectangle : ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n\nInput width of the rectangle : ");
                    int width = Convert.ToInt32(Console.ReadLine());
                    area = (length * width);
                    showOutput();
                    break;
                case 3:
                    Console.Write("\n\nInput base of the triangle : ");
                    int baseOfTriangle = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n\nInput height of the triangle : ");
                    int heightOfTriangle = Convert.ToInt32(Console.ReadLine());
                    area = (5 * baseOfTriangle * heightOfTriangle);
                    showOutput();
                    break;
                default:
                    showOutput();
                    break;
            }
        }

        //Program to read any Month Number in integer and display the number of days for this month
        static void displayNumberOfDaysInAMonth()
        {
            Console.Write("\n\nRead month number and display number of days for that month : ");
            Console.Write("\n\n------------------");
            Console.Write("\n\nInput Month No : ");
            int monthNo = Convert.ToInt32(Console.ReadLine());
            void showOutput(int days) => Console.Write("\n\nMonth has {0} days", days);
            switch (monthNo)
            {
                case 1:
                    showOutput(31);
                    break;
                case 2:
                    Console.Write("\n\n-> The 2nd Month is February and has 28 days\n\n-> In leap year, the February month has 29 days");
                    break;
                case 3:
                    showOutput(31);
                    break;
                case 4:
                    showOutput(30);
                    break;
                case 5:
                    showOutput(31);
                    break;
                case 6:
                    showOutput(30);
                    break;
                case 7:
                    showOutput(31);
                    break;
                case 8:
                    showOutput(31);
                    break;
                case 9:
                    showOutput(30);
                    break;
                case 10:
                    showOutput(31);
                    break;
                case 11:
                    showOutput(30);
                    break;
                case 12:
                    showOutput(31);
                    break;
                default:
                    Console.Write("\n\nInvalid Month number, Please try again...");
                    break;
            }
        }

        //Program to read any Month Number in integer and display Month name in the word
        static void displayNameOfInputMonth()
        {
            String[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.Write("\n\nRead month number and display month name : ");
            Console.Write("\n\n------------------");
            Console.Write("\n\nInput Month No : ");
            int monthNo = Convert.ToInt32(Console.ReadLine());
            void showOutput() => Console.Write("\n\n{0}", monthNames[monthNo - 1]);
            switch (monthNo)
            {
                case 1:
                    showOutput();
                    break;
                case 2:
                    showOutput();
                    break;
                case 3:
                    showOutput();
                    break;
                case 4:
                    showOutput();
                    break;
                case 5:
                    showOutput();
                    break;
                case 6:
                    showOutput();
                    break;
                case 7:
                    showOutput();
                    break;
                case 8:
                    showOutput();
                    break;
                case 9:
                    showOutput();
                    break;
                case 10:
                    showOutput();
                    break;
                case 11:
                    showOutput();
                    break;
                case 12:
                    showOutput();
                    break;
                default:
                    Console.Write("\n\nInvalid Month number, Please try again...");
                    break;
            }
        }

        //Program to read any day number in integer and display day name in the word
        static void displayDayName() {
            Console.Write("\n\nAccept day number and display its equivalent day name in word : ");
            Console.Write("\n\n----------------------------------------------------------------");
            Console.Write("\n\nInput Day No : ");
            int dayNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            switch (dayNo)
            {
                case 1:
                    Console.Write("Monday");
                    break;
                case 2:
                    Console.Write("Tuesday");
                    break;
                case 3:
                    Console.Write("Wednesday");
                    break;
                case 4:
                    Console.Write("Thursday");
                    break;
                case 5:
                    Console.Write("Friday");
                    break;
                case 6:
                    Console.Write("Saturday");
                    break;
                case 7:
                    Console.Write("Sunday");
                    break;
                default:
                    Console.Write("\n\nInvalid day number. Please try again...");
                    break;
            }
        
        }

        //Program to read any digit, display in the word.
        static void displayWordForDigits()
        {
            int inputDigit;
            Console.Write("\n\nAccept digit and display in word : ");
            Console.Write("\n\n-----------------------------------");
            Console.Write("\n\nInput Digit(0-9) : ");
            inputDigit = Convert.ToInt32(Console.ReadLine());
            switch (inputDigit)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("\nInvalid digit. Please try again...");
                    break;
            }
        }

        //Program to accept a grade and display the equivalent description
        static void displayGradeAndItsEquivalent()
        {
            string gradeEquivalent;
            char grade;
            Console.Write("\n\nAccept a grade and display equivalent description : ");
            Console.Write("\n\n---------------------------------------------------");
            Console.Write("\n\nInput the grade :");
            grade = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (grade)
            {
                case 'E':
                    gradeEquivalent = "Excellent";
                    break;
                case 'V':
                    gradeEquivalent = "Very Good";
                    break;
                case 'G':
                    gradeEquivalent = "Good";
                    break;
                case 'A':
                    gradeEquivalent = "Average";
                    break;
                case 'F':
                    gradeEquivalent = "Fails";
                    break;
                default:
                    gradeEquivalent = "Invalid Grade";
                    break;
            }
            Console.Write("\n\nYou have chosen  : {0}\n", gradeEquivalent);
        }

        //Program to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer
        static void getCustomerElectricityBill()
        {
            int customerID, consumedUnits;
            double charge, surCharge = 0, chargePerUnit, netAmount;
            string customerName;

            Console.Write("\n\nCalculate Electricity Bill : ");
            Console.Write("\n\n----------------------------");
            Console.Write("\n\nInput Customer ID : ");
            customerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput Customer Name : ");
            customerName = Console.ReadLine();
            Console.Write("\n\nUnits consumed by the customer : ");
            consumedUnits = Convert.ToInt32(Console.ReadLine());
            if (consumedUnits < 200)
            {
                charge = 1.20;
            }
            else if (consumedUnits >= 200 && consumedUnits < 400)
            {
                charge = 1.50;
            }
            else if (consumedUnits >= 400 && consumedUnits < 600)
            {
                charge = 1.80;
            }
            else
            {
                charge = 2.00;
            }
            chargePerUnit = consumedUnits * charge;
            if (chargePerUnit > 300)
            {
                surCharge = chargePerUnit * 15 / 100.0;
            }
            netAmount = chargePerUnit + surCharge;
            if (netAmount < 100)
            {
                netAmount = 100;
            }
            Console.Write("\n\nElectricity Bill");
            Console.Write("\n\nCustomer ID                       : {0}", customerID);
            Console.Write("\nCustomer Name                       : {0}", customerName);
            Console.Write("\nUnits Consumed                       : {0}", consumedUnits);
            Console.Write("\nAmount Charges @Rs. {0}  per unit : {1}", charge, chargePerUnit);
            Console.Write("\nSurchage Amount                     : {0}", surCharge);
            Console.Write("\nNet Amount Paid By the Customer     : {0}", netAmount);
        }

        //program to calculate profit and loss on a transaction
        static void calculateProfitAndLoss()
        {
            int costPrice, sellingPrice, difference;
            Console.Write("\n\nCalculate profit and loss on a Transaction :");
            Console.Write("\n\n----------------------------");
            Console.Write("\n\nInput Cost Price: ");
            costPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nInput Selling Price: ");
            sellingPrice = Convert.ToInt32(Console.ReadLine());
            if (sellingPrice > costPrice)
            {
                difference = sellingPrice - costPrice;
                Console.Write("\n\nYou can book your profit amount : {0}\n", difference);
            }
            else if (costPrice > sellingPrice)
            {
                difference = costPrice - sellingPrice;
                Console.Write("\n\nYou got a loss of amount : {0}\n", difference);
            }
            else
            {
                Console.Write("\n\nYou are running in no profit no loss condition.\n");
            }
        }
    }
}
