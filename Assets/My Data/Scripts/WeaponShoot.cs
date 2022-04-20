using System.Collections;
using UnityEngine;

namespace Asteroid
{
    internal class WeaponShoot : IWeapon
    {
        public float BulletForce { get; protected set; }

        public WeaponShoot(float bulletForce)
        {
            BulletForce = bulletForce;
        }

        public void Shoot(Rigidbody2D _bullet, Transform transform)
        {
            _bullet.AddForce(transform.up * BulletForce);
        }
    }
}

