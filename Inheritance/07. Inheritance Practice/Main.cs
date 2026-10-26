namespace ObjectOriented.Inheritance.InheritancePracticeSiege;

public class Siege
{
    public double MaxSpeed { get; set; }
    public double Efficiency { get; set; }

    public Siege(double maxSpeed, double efficiency)
    {
        MaxSpeed = maxSpeed;
        Efficiency = efficiency;
    }

    public virtual double GetTripCost(double distance, double foodPrice)
    {
        return (distance / Efficiency) * foodPrice;
    }

    public virtual double? GetCargoVolume()
    {
        return null;
    }
}

public class BatteringRam : Siege
{
    public double LoadWeight { get; set; }
    public double BedArea { get; set; }

    public BatteringRam(
        double maxSpeed,
        double efficiency,
        double loadWeight,
        double bedArea) : base(maxSpeed, efficiency)
    {
        LoadWeight = loadWeight;
        BedArea = bedArea;
    }

    public override double GetTripCost(double distance, double foodPrice)
    {
        var tripCostBase = base.GetTripCost(distance, foodPrice);
        return tripCostBase + (LoadWeight * 0.01);
    }

    public override double? GetCargoVolume()
    {
        return BedArea * 2;
    }
}

public class Catapult : Siege
{
    public double CargoVolume { get; set; }

    public Catapult(double maxSpeed, double efficiency, double cargoVolume) : base(maxSpeed, efficiency)
    {
        CargoVolume = cargoVolume;
    }

    public override double? GetCargoVolume()
    {
        return CargoVolume;
    }
}
