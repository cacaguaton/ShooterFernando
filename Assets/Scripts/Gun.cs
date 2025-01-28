using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _bulletPivot;
    public void shoot()
    {
        GameObject.Instantiate(_bullet,_bulletPivot.position,_bulletPivot.rotation);
    }
}
