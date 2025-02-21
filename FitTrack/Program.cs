namespace FitTrack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessTracker_base simpleTracker = new FitnessTracker_base("Haji's watch");
            FitTrackPro proTracker = new FitTrackPro("Haji's PRO watch");

            simpleTracker.AddUser("Haji");
            simpleTracker.AddUser("Haji");
            simpleTracker.AddUser("Haji");
            simpleTracker.AddUser("Haji");

            simpleTracker.TrackSteps(10000);
            simpleTracker.TrackSteps(35000);
            simpleTracker.TrackSteps(15000);

            simpleTracker.PrintInfo();

            proTracker.TrackSteps(75000);
            proTracker.TrackSteps(35000);
            proTracker.TrackSteps(175000);

            proTracker.AddUser("Haji");
            proTracker.AddUser("Haji");
            proTracker.AddUser("Haji");
            proTracker.AddUser("Haji");
            proTracker.AddUser("Haji");
            proTracker.AddUser("Haji");
            
        }
    }
}
