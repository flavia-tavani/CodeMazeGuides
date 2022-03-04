using InequalityVsIsNot;

var comparer = new InequalityVsIsNotComparer();

var vehicle = new Vehicle()
{
    SerialNumber = 1001,
    VehicleBrand = Brand.Toyota
};

var car = new Car()
{
    Model = "Fiesta",
    VehicleBrand = Brand.Ford
};

comparer.SerialNumberComparerUsingNotEqual(vehicle);

comparer.SerialNumberComparerUsingIsNot(vehicle);

comparer.VehicleNotEqualToNull(vehicle);

comparer.VehicleIsNotToNull(vehicle);

comparer.BoxedSerialNumberComparerUsingNotEqual(vehicle);

comparer.BoxedSerialNumberComparerUsingIsNot(vehicle);

comparer.BrandComparerUsingNotEqual(vehicle);

comparer.BrandComparerUsingIsNot(vehicle);

comparer.ModelComparerUsingNotEqual(car);

comparer.ModelComparerUsingIsNot(car);

comparer.AnotherModelComparerUsingIsNot(car);

comparer.CarTypeComparerUsingNotEqual(car);

comparer.CarTypeComparerUsingIsNot(car);

var otherVehicle = new Car()
{
    SerialNumber = 1001,
    VehicleBrand = Brand.Ford,
    Model = "Fiesta"
};

Console.WriteLine(car != otherVehicle);
Console.WriteLine(!car.Equals(otherVehicle));


var recordVehicle = new RecordCar()
{
    SerialNumber = 1001,
    VehicleBrand = Brand.Ford,
    Model = "Fiesta"
};

var otherRecordVehicle = new RecordCar()
{
    SerialNumber = 1001,
    VehicleBrand = Brand.Ford,
    Model = "Fiesta"
};

Console.WriteLine(recordVehicle != otherRecordVehicle);
Console.WriteLine(!recordVehicle.Equals(otherRecordVehicle));
