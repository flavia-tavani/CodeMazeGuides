namespace InequalityVsIsNot
{
    public class Car : Vehicle
    {
        public string? Model { get; set; }

        public bool Equals(Car otherCar)
        {
            return otherCar != null && Model == otherCar.Model;
        }
    }
}
