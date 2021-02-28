using Application;
using Domain;
using UnityEngine;

namespace Presentation
{
    public class SphereView : MonoBehaviour
    {
        private SphereApplicationService _sphereApplicationService;
        private Rigidbody _rigidbody;

        // Start is called before the first frame update
        private void Start()
        {
            _sphereApplicationService = new SphereApplicationService();
            _rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        private void Update()
        {
            UpdateMoveDirection();
        }

        private void UpdateMoveDirection()
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

            _sphereApplicationService.ChangeSphereMoveDirection(new SphereMoveDirection(rawMoveDirection));
            var moveDirection = _sphereApplicationService.GetMoveDirection();
            _rigidbody.AddForce(new Vector3(moveDirection.Value.x, 0, moveDirection.Value.y) * 5);
        }
    }
}