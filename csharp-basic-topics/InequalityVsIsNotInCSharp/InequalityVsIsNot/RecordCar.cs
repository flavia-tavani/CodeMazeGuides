using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InequalityVsIsNot
{
    public record RecordCar : RecordVehicle
    {
        public string? Model { get; set; }

        public virtual bool Equals(RecordCar? otherCar)
        {
            return otherCar is not null && Model == otherCar.Model
                && VehicleBrand == Brand.Ford;
        }
    }
}
