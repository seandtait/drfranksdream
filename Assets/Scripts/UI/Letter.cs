using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    public TMPro.TextMeshProUGUI requestText;

    public void SetRequestText(string text)
    {
        requestText.text = text;
    }

}
