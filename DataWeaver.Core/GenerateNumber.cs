
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace DataWeaver.Core
{
    public class GenerateNumber
    {
        //public static T Generate<T>(T min, T max) where T : INumber<T>
        //{
        //    if (min > max)
        //    {
        //        throw new ArgumentException("Minimum value cannot be greater than maximum value.");
        //    }
        //    return (T)Convert.ChangeType(RandomNumberGenerator.GetItems(min, max), typeof(T));
        //}
        public int Generate(int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
            }
            Random random = new Random();
            return random.Next(min, max);
        }
        public double Generate(double min, double max)
        {
            if (min > max)
            {
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
            }
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
        public double Generate(float min, float max)
        {
            if (min > max)
            {
                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
            }
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }
    }
}
