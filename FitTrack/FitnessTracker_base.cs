using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack
{
    public class FitnessTracker_base
    {
        protected int _totalSteps = 0;
        protected int _userIndex = 0;
        protected int _stepsLimit = 0;
        protected string DeviceName { get; set; }
        protected int BatteryLife { get; set; }
        private int TotalSteps { get; set; }
        protected string[] Users { get; set; }

        protected string CurrentActivity { get; set; }

        public FitnessTracker_base(string name)
        {
            DeviceName = name;
            BatteryLife = 24;
            TotalSteps = 0;
            Users = new string[3];
            _stepsLimit = 50000;
        }

        public virtual void TrackSteps(int steps)
        {
            if (steps > 1 && steps < _stepsLimit)
            {
                _totalSteps += steps;
                Console.WriteLine($"You have tracked {steps} steps. Total is {_totalSteps}");
            }
            else { Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 50,000."); }
        }

        public virtual void AddUser(string userName)
        {
            if (_userIndex >= 3)
            {
                Console.WriteLine("Cannot add more users. The limit of 3 users has been reached.");
                return;
            }

            Users[_userIndex] = userName;
            Console.WriteLine($"User {userName} has been added successfully!");
            _userIndex++;
        }

       


        public void DeleteUsers(string name)
        {
            int i = Array.IndexOf(Users, name);

            if (i > -1)
            {
                Console.WriteLine($"User {Users[i]} has been deleterd.");
                Users[i] = null;
                _userIndex--;
            }
            else
            {
                Console.WriteLine("User not found. No user was deleted.");
            }
        }

        public void SetCurrentActivity (string activity)
        {
            CurrentActivity = activity;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"FitTrack Pro is called {DeviceName}, it has {BatteryLife} hours of battery life, {_totalSteps} total steps, and {_userIndex} users. Current activity is {CurrentActivity}.");
        }

    }
}
