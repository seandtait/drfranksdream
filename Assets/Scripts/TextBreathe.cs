using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBreathe : MonoBehaviour
{
    float magnitude = 2f;
    bool increase = true;
    float starting;

    float speed = 3f;

    public TMPro.TextMeshProUGUI textbox;

    // Start is called before the first frame update
    void Start()
    {
        starting = textbox.fontSize;
    }

    // Update is called once per frame
    void Update()
    {
        if (!textbox)
        {
            return;
        }

        if (increase)
        {
            textbox.fontSize += Time.deltaTime * speed;

            if (textbox.fontSize >= starting + magnitude)
            {
                increase = false;
            }
        } else
        {
            textbox.fontSize -= Time.deltaTime * speed;

            if (textbox.fontSize <= starting - magnitude)
            {
                increase = true;
            }
        }

        
    }
}
