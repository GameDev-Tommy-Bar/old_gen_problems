using UnityEngine;

public class MoveCar : MonoBehaviour
{
    [SerializeField] private bool isMovingRight = true;
    [SerializeField] private float speed = 1f;
    
    private Vector3 moveFactor = new Vector3(0.1f, 0f, 0f);

    private void Start()
    {
        if (isMovingRight)
        {
            transform.Rotate(new Vector3(0f, 180f, 0f));
        }
    }

    private void Update()
    {
        // if (kid.GetComponent<Collider2D>().IsTouching(old_guy.GetComponent<Collider2D>()))
        // {
        //     speed = 0.1f;
        // }
        
        transform.position += moveFactor * (isMovingRight ? speed : -speed) * Time.deltaTime;
    }
}
