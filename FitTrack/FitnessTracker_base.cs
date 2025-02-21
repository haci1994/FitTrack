﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack
{
    public class FitnessTracker_base
    {
        private int _totalSteps = 0;
        private int _userIndex = 0;
        private string DeviceName { get; set; }
        private int BatteryLife { get; set; }
        private int TotalSteps { get; set; }
        private string[] Users { get; set; }
        
        public FitnessTracker_base(string name)
        {
            DeviceName = name;
            BatteryLife = 24;
            TotalSteps = 0;
            Users = new string[3];
        }

        public void TrackSteps (int steps)
        {
            if (steps > 1 && steps < 50000)
            {
                _totalSteps += steps;
                Console.WriteLine($"You have tracked {steps} steps. Total is {_totalSteps}");
            }
            else { Console.WriteLine("Invalid number of steps. Please enter a value between 1 and 50,000."); }
        }

        public void AddUser(string userName)
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

        public void PrintInfo ()
        {
            Console.WriteLine($"FitTrack Pro is called {DeviceName}, it has {BatteryLife} hours of battery life, {_totalSteps} total steps, and {_userIndex} users.");
        }
    }
}
