
namespace AbstractClassAndInterface.AbstractClass
{
    public class Car : Vehicle
    {
        double mDistance, mTime = 0.0;

        public override double Distance
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

        public override double Time
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

        public override double Speed()
        {
            double speed = 0.0;
            double hours = mTime / 60;
            speed = mDistance / hours;
            return speed;
        }
    }
}
