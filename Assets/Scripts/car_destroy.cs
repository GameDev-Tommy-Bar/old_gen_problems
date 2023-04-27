using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "car"){
            //Debug.Log("car collision");
            Destroy(other.gameObject);
        }
    }
}
