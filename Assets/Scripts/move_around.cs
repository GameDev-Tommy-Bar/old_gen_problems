using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_around : MonoBehaviour
{
    Vector3 pos;
    Vector3 curr_pos;
    [SerializeField]float move_factor_lim = 3f;
    [SerializeField]Vector3 move_factor = new Vector3(0.1f,0,0);
    [SerializeField]float speed = 15f;
    Vector3 rotation = new Vector3(0,180,0);
    bool move_right = true;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    // Update is called once per frame
    }
    void Update()
    {

        //curr_pos = transform.position; 
        if(transform.position.x > pos.x + move_factor_lim){
            move_right = false;
            transform.Rotate(rotation);
        }
        if(transform.position.x < pos.x - move_factor_lim){
            move_right = true;
            transform.Rotate(rotation);
        }
        if(move_right){
            GetComponent<Transform>().position += move_factor*speed*Time.deltaTime;
        }
        else{
           GetComponent<Transform>().position -= move_factor*speed*Time.deltaTime;
        }
        
    }
    

}
