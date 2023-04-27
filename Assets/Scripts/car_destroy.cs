using UnityEngine;

public class CarDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("car"))
        {
            Destroy(other.gameObject);
        }
    }
}
