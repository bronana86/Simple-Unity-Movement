using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SimpleTextUpdate : MonoBehaviour
{

    public TMP_Text text;
    public string titleText
    [SerializeField]
    string rightText;
    string leftText;
    Font titleFont = (Font)Resources.GetBuiltinResource (typeof(Font), "Liberation Sans SDF.ttf");
    Font rightFont = (Font)Resources.GetBuiltinResource (typeof(Font), "Dongle-Regular SDF.ttf");
    Font leftFont = (Font)Resources.GetBuiltinResource (typeof(Font), "Comforter-Regular SDF.ttf");
    //text.renderer.sharedMaterial = ArialFont.material;

    // Start is called before the first frame update
    void Start()
    {
        textMesh.font = titleFont;
        text.text = newText;
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
            text.font = leftFont
        }
        if (Input.GetKeyDowm(KeyCode.Space)){
            text.text = titleText;
            text.font = titleFont;
        }
    }
}
