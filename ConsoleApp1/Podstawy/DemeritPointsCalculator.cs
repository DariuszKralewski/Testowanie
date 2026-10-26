using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Podstawy
{
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 50; // limit prędkości w km/h
        private const int MaxSpeed = 300; // maksymalna prędkość, którą można wprowadzić
        private const int PointsPer5KmOverLimit = 1; // za każde 5 km/h powyżej limitu prędkości kierowca otrzymuje 1 punkt karny

        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > MaxSpeed)
                throw new ArgumentOutOfRangeException($"Speed must be between 0 and {MaxSpeed} km/h.");

            if (speed <= SpeedLimit)
                return 0; // brak punktów karnych

            int points = (speed - SpeedLimit) / 5; // obliczanie punktów karnych
            return points;
        }
    }
}
