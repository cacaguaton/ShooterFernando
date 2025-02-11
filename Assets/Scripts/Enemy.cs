using System;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private string _enemyTolook = "Player";
    [SerializeField]
    private float speed = 1f;
    private Transform objetive;
    private Health _health;
    private void Start()
    {
        objetive = GameObject.FindGameObjectWithTag(_enemyTolook).transform;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            _health.TakeDamage(1);
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
    private void Uptate()
    {
        FollowObjetive();
    }
    private void FollowObjetive()
    {
        Vector3 direction = (objetive.position - transform.position).normalized;
        transform.position+= direction * speed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(direction);


    }
    void Update()
    {
        FollowObjective();
    }
    private void FollowObjective()
    {
        Vector3 direction=(objetive.position-transform.position).normalized;
        transform.position+=direction * speed * Time.deltaTime;
        transform.rotation=Quaternion.LookRotation(direction);
    }
}
