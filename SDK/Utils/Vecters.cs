using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.SDK
{
    class Vecters
    {
        public struct Vec3f
        {
            public float x;
            public float y;
            public float z;
        }

        public static List<float> directionalVector2(float yaw, float pitch)
        {
            List<float> calculations = new List<float>();
            calculations.Add((float)Math.Cos(yaw) * (float)Math.Cos(pitch));
            calculations.Add((float)Math.Sin(pitch));
            calculations.Add((float)Math.Sin(yaw) * (float)Math.Cos(pitch));
            return calculations;
        }

        public static Vec3f directionalVector(float yaw, float pitch)
        {
            Vec3f vec3 = new Vec3f();
            vec3.x = (float)Math.Cos(yaw) * (float)Math.Cos(pitch);
            vec3.y = (float)Math.Sin(pitch);
            vec3.z = (float)Math.Sin(yaw) * (float)Math.Cos(pitch);
            return vec3;
        }
        public struct Vec2f
        {
            public float x;
            public float y;
        }
    }
}
