using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate((Vector2.left * Time.deltaTime) *speed);
        }
    }
}
