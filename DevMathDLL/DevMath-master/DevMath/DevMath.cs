using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            float aValue = a;
            float bValue = b;
            float tValue = t;
            return (aValue + ((bValue - aValue) * tValue));
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            float distanceTraveled = 0;
            float vi = startVelocity;
            float a = acceleration;
            float t = time;

            distanceTraveled = (vi * t) + (0.5f * ((a * t) * (a * t)));
            return distanceTraveled;
        }

        public static float Clamp(float value, float min, float max)
        {
            float v = value;
            float mi = min;
            float ma = max;

            if (v > mi && v < ma)
            {
                return v;
            }
            else if (v < mi)
            {
                return mi;
            }
            else
            {
                return ma;
            }
        }

        public static float RadToDeg(float angle)
        {
            float a = angle;
            a *= 57.2957795f;
            return a;
        }

        public static float DegToRad(float angle)
        {
            float a = angle;
            a /= 57.2957795f;
            return a;
        }
    }
}
