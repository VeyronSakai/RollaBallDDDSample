using System;
using UnityEngine;

namespace Domain
{
    /// <summary>
    /// Entity
    /// </summary>
    public class Sphere
    {
        public SphereId SphereId { get; }
        public SphereMoveDirection MoveDirection { get; private set; }
        public SphereAcceleration Acceleration { get; private set; }

        private const float InitialAcceleration = 5;

        public Sphere(SphereId sphereId)
        {
            SphereId = sphereId ?? throw new ArgumentNullException();
            MoveDirection = new SphereMoveDirection(Vector2.zero);
            Acceleration = new SphereAcceleration(InitialAcceleration);
        }

        public void ChangeMoveDirection(SphereMoveDirection moveDirection)
        {
            MoveDirection = moveDirection;
        }
    }
}