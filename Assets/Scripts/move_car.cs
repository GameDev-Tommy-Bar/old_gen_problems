using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_car : MonoBehaviour
{
    [SerializeField] bool isMovingRight = true;
    [SerializeField] public float speed = 1f;
    //public GameObject kid;
    //public GameObject old_guy;
    Vector3 move_factor;
    // Start is called before the first frame update
    void Start()
    {
        if(isMovingRight) transform.Rotate(new Vector3(0, 180, 0));
        move_factor = new Vector3(0.1f,0,0);
    }
    // Update is called once per frame
    void Update()
    {
        // if (kid.GetComponent<Collider2D>().IsTouching(old_guy.GetComponent<Collider2D>())){
        //     speed = 0.1f;
        // }
        if(isMovingRight) GetComponent<Transform>().position += move_factor*speed;
        else GetComponent<Transform>().position -= move_factor*speed;
        
    }
}
