using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Triggers : MonoBehaviour
{
    // Start is called before the first frame update
    public MonoBehaviour scriptToDisable;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "kid"){
            //ebug.Log("hi kid");
            other.transform.parent = this.transform;
            Disable();
        }
        if(other.tag == "car"){
            //Debug.Log("hi car");
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
    public void Disable() {
        // disable the script
        scriptToDisable.enabled = false;
    }
    
}
