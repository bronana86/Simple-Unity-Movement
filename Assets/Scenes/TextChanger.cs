using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{

    public TMP_Text text;
    public string titleText;
    public string rightText;
    public string leftText;
    public TMP_FontAsset titleFont;
    public TMP_FontAsset rightFont;
    public TMP_FontAsset leftFont;

    // Start is called before the first frame update
    void Start()
    {
        text.font = titleFont;
        text.text = titleText;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            text.text = rightText;
            text.font = rightFont;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            text.text = leftText;
            text.font = leftFont;
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            text.text = titleText;
            text.font = titleFont;
        }
    }
}
