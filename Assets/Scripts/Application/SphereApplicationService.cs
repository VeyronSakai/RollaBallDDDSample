using System;
using Domain;
using UnityEngine;

namespace Application
{
    public class SphereApplicationService
    {
        private readonly ISphereFactory _sphereFactory;
        private readonly ISphereRepository _sphereRepository;

        public SphereApplicationService(ISphereFactory sphereFactory, ISphereRepository sphereRepository)
        {
            _sphereFactory = sphereFactory;
            _sphereRepository = sphereRepository;
        }

        public void Create(SphereId sphereId)
        {
            var sphere = _sphereFactory.Create(sphereId);
            _sphereRepository.Save(sphere);
        }

        public Sphere MoveSphere(SphereId sphereId, Vector2 rawMoveDir)
        {
            var sphere = _sphereRepository.Find(sphereId);
            if (sphere == null)
            {
                throw new ArgumentNullException();
            }

            sphere.ChangeMoveDirection(new SphereMoveDirection(rawMoveDir));

            return sphere;
        }
    }
}