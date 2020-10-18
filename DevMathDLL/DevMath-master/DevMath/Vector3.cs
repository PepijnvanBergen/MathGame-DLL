using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //hier stond geen static
        public static float Magnitude(Vector3 v1, Vector3 v2)
        {
            Vector3 delta = new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
            float magnitude = (float)Math.Sqrt(((delta.x * delta.x) + (delta.y * delta.y) + (delta.z * delta.z)));
            return magnitude;
        }

        //Hier stond geen static
        public static Vector3 Normalized(Vector3 v)
        {
            float vMag = Vector3.Magnitude(v, new Vector3(0, 0, 0));
            Vector3 normalizedVector = new Vector3(v.x / vMag, v.y / vMag, v.z / vMag);
            return normalizedVector;
        }

        public static implicit operator Vector3(Vector2 v)
        {
            Vector3 newVector3 = new Vector3(v.x, v.y, 0);
            return newVector3;
        }

        public static float Dot(Vector3 v1, Vector3 v2)
        {
            float dot = ((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
            return dot;
        }

        public static Vector3 Cross(Vector3 v1, Vector3 v2)
        {
            return new Vector3(((v1.y * v2.z) - (v1.z * v2.y)), ((v1.z * v2.x) - (v1.x * v2.z)), ((v1.x * v2.y) - (v1.y * v2.x)));
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            return new Vector3((a.x += (b.x -= a.x) * t), (a.y += (b.y -= a.y) * t), (a.z += (b.z -= a.z) * t));
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            Vector3 add = new Vector3((v1.x + v2.x), (v1.y + v2.y), (v1.z + v2.z));
            return add;
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            Vector3 subtract = new Vector3((v1.x - v2.x), (v1.y - v2.y), (v1.z - v2.z));
            return subtract;
        }

        public static Vector3 operator -(Vector3 v)
        {
            Vector3 negativeVector = new Vector3(v.x * -v.x, v.y * -v.y, v.z * -v.z);
            return negativeVector;
        }

        public static Vector3 operator *(Vector3 v, float scalar)
        {
            Vector3 scaled = new Vector3((v.x * scalar), (v.y * scalar), (v.z * scalar));
            return scaled;
        }

        public static Vector3 operator /(Vector3 v, float scalar)
        {
            Vector3 scaled = new Vector3((v.x / scalar), (v.y / scalar), (v.z / scalar));
            return scaled;
        }
    }
}
