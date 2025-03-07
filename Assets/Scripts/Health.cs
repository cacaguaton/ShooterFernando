using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int _MaxHealth = 3;
    private int _currentHealth;
    [SerializeField]
    private UnityEvent _onDie;
    private void Start()
    {
        _currentHealth = _MaxHealth;
    }
    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <=0)
        {
            Die();
           
        }
    }
    private void Die()
    {
        _onDie?.Invoke();
    }
}