using System;
namespace OopCatExercise
{
    public abstract class Cat : ICat
    {
        public bool IsAsleep { get; private set; }
        public int AverageHeight { get; private set; }
        public string Setting { get; private set; }

        public Cat(bool isAsleep, int averageHeight, string setting)
        {
            IsAsleep = isAsleep;
            AverageHeight = averageHeight;
            Setting = setting;
        }

        public abstract string Eat();

        public virtual string Sleep()
        {
            return "dreaming";
        }

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }
    }
}
