﻿using UnityEngine;

namespace Asteroid
{
    internal sealed class RotationShip : IRotation
    {
        private readonly Transform _transform;

        public RotationShip(Transform transform)
        {
            _transform = transform;
        }

        public void Rotation(Vector3 direction)
        {
            var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90;
            _transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}

