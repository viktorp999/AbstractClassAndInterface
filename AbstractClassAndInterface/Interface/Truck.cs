
namespace AbstractClassAndInterface.Interface
{
    public class Truck : IVehicle
    {
        double mDistance, mTime = 0.0;

        public double Distance
        {
            get
            {
                return mDistance;
            }
            set
            {
                if (value <= 0)
                {
                    mDistance = 1;
                }
                else
                {
                    mDistance = value;
                }
            }
        }

        public double Time
        {
            get
            {
                return mTime;
            }
            set
            {
                if (value <= 0)
                {
                    mTime = 1;
                }
                else
                {
                    mTime = value;
                }
            }
        }

        public double Speed()
        {
            double speed = 0.0;
            double hours = mTime / 60;
            speed = mDistance / hours;
            return speed;
        }
    }
}
