using UnityEngine;

public class OldGuyMove : MonoBehaviour
{
    private Vector3 posUpDown;
    private Vector3 posRightLeft;
    [SerializeField] private float speed = 10f;

    private void Start()
    {
        posUpDown = new Vector3(0f, 0.1f, 0f);
        posRightLeft = new Vector3(0.1f, 0f, 0f);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += posUpDown * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= posUpDown * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += posRightLeft * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= posRightLeft * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("kid"))
        {
            speed = 50f;
        }
    }
}
