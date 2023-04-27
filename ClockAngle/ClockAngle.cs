using System;

public class ClockAngle
{
    public static void Main(string[] args)
    {
        start();
    }
    
    static void start(){
        
        int hours = getH();
        while(hours > 12 || hours <= 0){
            hours = getH();
        }
        int mins = getM();
        while(mins > 59 || mins < 0){
            mins = getM();
        }

        double result = solve(hours, mins);
        
        if (result > 180){
            result = 360 - result;
        }
        
        Console.WriteLine("Angle is: ");
        Console.WriteLine(result + "°");
    }

    static int getH(){
        Console.WriteLine("Enter hours: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int getM(){
        Console.WriteLine("Enter minutes: ");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    static double solve(int hours, int mins){
        double temp1 = (Convert.ToDouble(hours) + Convert.ToDouble(mins)/60) * 30;
        if (hours >= 6){
            double temp2 = mins * 6;
            temp1 = Math.Abs(temp1 - temp2);
        }
        return temp1;
    }
}