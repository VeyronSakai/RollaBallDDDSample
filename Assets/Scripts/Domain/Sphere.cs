using UnityEngine;

/// <summary>
/// Entity
/// </summary>
public class Sphere
{
    public SphereMoveDirection MoveDirection { get; private set; }

    public Sphere()
    {
        MoveDirection = new SphereMoveDirection(Vector2.zero);
    }

    public void ChangeMoveDirection(SphereMoveDirection moveDirection)
    {
        MoveDirection = moveDirection;
    }
}