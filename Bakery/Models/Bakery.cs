using System;

namespace Bakery.Logic
{
    public class Bread
    {
        public int loafCount { get; set; }
        public static int costOfBread(int loafCount)
        {   
        int totalCost = 0;
        for (int loaves = 0; loaves <= loafCount; loaves++)
        if (loaves%3 == 1)
        {
        totalCost += 5;
        }
        else if (loaves%3 == 2)
        {
        totalCost +=5;
        }
        else if (loaves%3 == 0)
        {
        totalCost +=0;
        }
        return totalCost;
        }
    }
    public class Pastry
    {
        public static int costOfPastry(int pastryCount)
        {
        int pastryCost = 0;
        int pastries = pastryCount;
        if (pastries == 1)
        {
        pastryCost = 2;
        }
        else if (pastries == 2)
        {
        pastryCost = 4;
        }
        else if (pastries == 3)
        {
        pastryCost = 5;
        }
        else if (pastries == 4)
        {
        pastryCost = 7;
        }
        else if (pastries == 5)
        {
        pastryCost = 9;
        }
        else if (pastries == 6)
        {
        pastryCost = 10;
        }
        return pastryCost;
        }
    }
}
