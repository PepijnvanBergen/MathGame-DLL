﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }

        public float Acceleration
        {
            get; private set;
        }

        public float mass = 1.0f;

        public float frictionCoefficient;
        public float normalForce;

        public void UpdateVelocityWithForce(Vector2 forceDirection, float forceNewton, float deltaTime)
        {
            float force = forceNewton - (normalForce * frictionCoefficient);
            float acceleration = force * mass * deltaTime;
            Velocity = new Vector2(acceleration, acceleration);
            return;
        }
    }
}
