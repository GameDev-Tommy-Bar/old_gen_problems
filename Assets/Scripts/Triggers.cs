using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{
    public MonoBehaviour scriptToDisable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("kid"))
        {
            other.transform.parent = transform;
            Disable();
        }
        else if (other.CompareTag("car"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void Disable()
    {
        scriptToDisable.enabled = false;
    }
}