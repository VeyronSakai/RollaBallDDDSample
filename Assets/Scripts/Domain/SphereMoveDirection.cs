using UnityEngine;

namespace Domain
{
    /// <summary>
    /// ValueObject
    /// </summary>
    public readonly struct SphereMoveDirection
    {
        public Vector2 Value { get; }

        public SphereMoveDirection(Vector2 value)
        {
            Value = value == Vector2.zero ? Vector2.zero : value.normalized;
        }
    }
}