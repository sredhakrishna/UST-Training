﻿// UtilityCar class

public class UtilityCar : Car

{

    public bool RearCoolingVents { get; set; }

    // Constructor

    public UtilityCar(long id, string name, bool rearCoolingVents)

    {

        Id = id;

        Name = name;

        RearCoolingVents = rearCoolingVents;

    }

    // Implementing abstract method from Car class

    public override double CalculateDriveCost(double km)

    {

        return 18 * km;

    }

}
