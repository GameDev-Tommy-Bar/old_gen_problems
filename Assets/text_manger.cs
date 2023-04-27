using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class text_manger : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI time_text;
    float time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        time_text.text =  "Time: " + time.ToString("F2");
        // core = Int32.Parse(scoreText.text);
        //         score += 1;
        //         scoreText.text = ""+score;
    }
}
