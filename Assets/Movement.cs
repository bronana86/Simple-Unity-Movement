using System.Collections;
using System.Collections.Generic;
using UnityEngine;

float speed = 1.0f;
public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.Translate((Vector2.left * Time.deltaTime) *speed);
        }
    }
}
