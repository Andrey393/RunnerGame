using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextGlasses : MonoBehaviour
{
    public TMP_Text textGlasses;
    public int glasses;

    private void Start() 
    {
        glasses = 0;
        textGlasses.text = glasses.ToString();

    }

    private void Update() 
    {
        textGlasses.text = glasses.ToString();

    }

}
