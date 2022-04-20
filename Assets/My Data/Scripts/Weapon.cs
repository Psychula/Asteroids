using UnityEngine;

namespace Asteroid
{
    internal sealed class Weapon : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private float _bulletForce;

        private WeaponShoot _weaponShoot;

        private void Start()
        {
            _weaponShoot = new WeaponShoot(_bulletForce);
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                var Bullet = Instantiate(_bullet, transform.position, transform.rotation);
                _weaponShoot.Shoot(Bullet, transform);
                //РЕАЛИЗОВАТЬ УДАЛЕНИЕ ПУЛИ
            }
        }
    }
}

