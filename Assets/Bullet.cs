using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigiBody;
    
    [SerializeField]
    private float _bulletSpeed;
    private void OnEnable()
    {
        if(_rigiBody == null)
        {
            _rigiBody = gameObject.GetComponent<Rigidbody>();
        }

        _rigiBody.AddForce(transform.forward * _bulletSpeed, ForceMode.Impulse);
    }
}
