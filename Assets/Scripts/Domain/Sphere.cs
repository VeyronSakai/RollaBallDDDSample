using UnityEngine;

namespace Domain
{
    /// <summary>
    /// Entity
    /// </summary>
    public class Sphere
    {
        public SphereMoveDirection MoveDirection { get; private set; }
        public SphereAcceleration Acceleration { get; private set; }

        public Sphere()
        {
            MoveDirection = new SphereMoveDirection(Vector2.zero);
            Acceleration = new SphereAcceleration(5);
        }

        public void ChangeMoveDirection(SphereMoveDirection moveDirection)
        {
            MoveDirection = moveDirection;
        }
    }
}