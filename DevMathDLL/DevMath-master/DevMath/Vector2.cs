using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        //Deze was eerst niet static?
        public static float Magnitude(Vector2 v1, Vector2 v2)
        {
            float mag = (((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y)));
            float magnitude = (float)Math.Sqrt(mag);
            return magnitude;
        }
        //Deze was eerst ook niet static
        public static Vector2 Normalized(Vector2 v1)
        {
            float vMag = Vector2.Magnitude(v1, new Vector2(0, 0));
            Vector2 normalizedVector = new Vector2(v1.x / vMag, v1.y / vMag);
            return normalizedVector;
        }

        public static float Dot(Vector2 v1, Vector2 v2)
        {
            float dot = (v1.x * v2.x) + (v1.y * v2.y);
            return dot;
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return new Vector2((a.x += (b.x -= a.x) * t), (a.y += (b.y -= a.y) * t));
        }

        public static float Angle(Vector2 v1, Vector2 v2)
        {
            float ax = (v1.x - v2.x);
            float ay = (v1.y - v2.y);
            float angle = (float)Math.Atan2(ay, ax);
            return angle;
        }

        public static Vector2 DirectionFromAngle(float angle)
        {
            return -DevMath.RadToDeg((float)Math.Atan2(v.x, v.y));
        }

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            Vector2 add = new Vector2((v1.x + v2.x), (v1.y + v2.y));
            return add;
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            Vector2 subtract = new Vector2((v1.x - v2.x), (v1.y - v2.y));
            return subtract;
        }

        public static Vector2 operator -(Vector2 v)
        {
            Vector2 negativeVector = new Vector2(v.x * -v.x, v.y * -v.y);
            return negativeVector;
        }

        public static Vector2 operator *(Vector2 v, float scalar)
        {
            Vector2 scaled = new Vector2((v.x * scalar), (v.y * scalar));
            return scaled;
        }

        public static Vector2 operator /(Vector2 v, float scalar)
        {
            Vector2 scaled = new Vector2(v.x / scalar, v.y / scalar);
            return scaled;
        }
    }
}
