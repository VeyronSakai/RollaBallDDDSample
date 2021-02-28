using UnityEngine;

/// <summary>
/// ValueObject
/// </summary>
public class SphereMoveDirection
{
    public Vector2 Value { get; }

    public SphereMoveDirection(Vector2 value)
    {
        Value = value == Vector2.zero ? Vector2.zero : value.normalized;
    }
}