using System;
using Application;
using Domain;
using Infrastructure;
using UnityEngine;

namespace Presentation
{
    public class SphereView : MonoBehaviour
    {
        private SphereApplicationService _sphereApplicationService;
        private SphereId _sphereId;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _sphereApplicationService =
                new SphereApplicationService(new SphereFactory(), new SphereRepository());
            _sphereId = new SphereId(Guid.NewGuid());
            _sphereApplicationService.Create(_sphereId);
        }

        // Update is called once per frame
        private void Update()
        {
            var rawMoveDir = GetRawMoveDirection();
            var sphere = _sphereApplicationService.MoveSphere(_sphereId, rawMoveDir);
            var moveDir = sphere.MoveDirection;
            var acceleration = sphere.Acceleration;
            _rigidbody.AddForce(new Vector3(moveDir.Value.x, 0, moveDir.Value.y) * acceleration.Value);
        }

        private static Vector2 GetRawMoveDirection()
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

            return rawMoveDirection;
        }
    }
}