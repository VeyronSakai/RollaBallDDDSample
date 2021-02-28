using Application;
using UnityEngine;

namespace Presentation
{
    public class SphereView : MonoBehaviour
    {
        private SphereApplicationService _sphereApplicationService;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _sphereApplicationService = new SphereApplicationService(_rigidbody);
        }

        // Update is called once per frame
        private void Update()
        {
            _sphereApplicationService.MoveSphere();
        }
    }
}