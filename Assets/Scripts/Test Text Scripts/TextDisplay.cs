using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Textdisplay : MonoBehaviour
{
    public TMP_Text dispText;

    private int num = 0;
    // Update is called once per frame
    void Update()
    {
        dispText.text = num.ToString();
        if (Input.GetKeyDown("space")) num++;
    }
}


