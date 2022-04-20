using UnityEngine;

namespace Asteroid
{
    public interface IWeapon
    {
        public float BulletForce { get; }
        void Shoot(Rigidbody2D bullet, Transform transform);
    }

}

