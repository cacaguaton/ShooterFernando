using UnityEngine;

public class Player : MonoBehaviour
{
 private Health _health;
    private UIController uiController;
   
    void Start()
    {
        _health = GetComponent<Health>();
        uiController = GetComponent<UIController>();
        
    }
     private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            _health.TakeDamage(1);
            Vector3 pushDirection = (transform.position - collision.transform.position).normalized;
        }
    }
    public void Die()
    {
        uiController.ShowGameOverUI(true);
    }
}
