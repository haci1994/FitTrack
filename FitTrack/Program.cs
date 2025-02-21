namespace FitTrack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessTracker_base simpleTracker = new FitnessTracker_base("Haji's watch");

            simpleTracker.AddUser("Haji");
            simpleTracker.AddUser("Haji");

            simpleTracker.TrackSteps(10000);
            simpleTracker.TrackSteps(35000);
            simpleTracker.TrackSteps(15000);

            simpleTracker.PrintInfo();
            
        }
    }
}
