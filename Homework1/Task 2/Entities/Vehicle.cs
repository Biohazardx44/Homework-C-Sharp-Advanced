namespace Task_2.Entities
{
    public abstract class Vehicle
    {
        public bool IsGasFull = false;

        public bool IsBroken = true;

        public abstract void Drive();
    }
}