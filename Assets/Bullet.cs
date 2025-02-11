using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody _rigiBody;
    
    [SerializeField]
    private float _bulletSpeed;

     [SerializeField]
   private int _damage;
   public int damage
   {
      get {return _damage;}
   }
    private void OnEnable()
    {
        if(_rigiBody == null)
        {
            _rigiBody = gameObject.GetComponent<Rigidbody>();
        }

        _rigiBody.AddForce(transform.forward * _bulletSpeed, ForceMode.Impulse);
    }
}
