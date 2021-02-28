using Domain;
using UnityEngine;

namespace Application
{
    public class SphereApplicationService
    {
        private readonly Sphere _sphere;
        private readonly Rigidbody _rigidbody;

        public SphereApplicationService(Rigidbody rigidbody)
        {
            // SphereFactoryが生成すべき気がする
            _sphere = new Sphere();
            _rigidbody = rigidbody;
        }

        public void MoveSphere()
        {
            var rawMoveDirection = Vector2.zero;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rawMoveDirection += Vector2.left;
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                rawMoveDirection += Vector2.up;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                rawMoveDirection += Vector2.right;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                rawMoveDirection += Vector2.down;
            }
            
            _sphere.ChangeMoveDirection(new SphereMoveDirection(rawMoveDirection));
            var moveDirection = _sphere.MoveDirection;
            var acceleration = _sphere.Acceleration;
            _rigidbody.AddForce(new Vector3(moveDirection.Value.x, 0, moveDirection.Value.y) * acceleration.Value);
        }
    }
}