using UnityEngine;

public class Player : MonoBehaviour
{
    private Health health;
    private UIController uiController;
    private bool isPlaying = true;
    private void Start()
    {
        health =GetComponent<Health>();
        uiController = GetComponent<UIController>();
        SoundManager.instance.PlayMusic("Fondo");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && isPlaying)
        {
            health.TakeDamage(1);
            Vector3 pushDirection = (transform.position - collision.transform.position).normalized;
            transform.position += pushDirection * 0.5f;
        }
        else if (collision.gameObject.CompareTag("Key"))
        {
            isPlaying = false;
            uiController.ShowWinUI(true);
        }
    } 
    public void Die ()
    {
        uiController.ShowGameOverUI(true);
        isPlaying = false;
        SoundManager.instance.StopMusic();
         SoundManager.instance.Play("Muerte");
    }
}
