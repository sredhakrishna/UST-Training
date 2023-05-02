﻿// Sedan class

public class Sedan : Car

{

    public bool ABS { get; set; }

    public int BootSpace { get; set; }

    // Constructor

    public Sedan(long id, string name, bool abs, int bootSpace)

    {

        Id = id;

        Name = name;

        ABS = abs;

        BootSpace = bootSpace;

    }

    // Implementing abstract method from Car class

    public override double CalculateDriveCost(double km)

    {

        double cost = 0;

        if (BootSpace > 600)

            cost = 15 + (15 * 0.20);

        else

            cost = 15;

        return cost * km;

    }

}
