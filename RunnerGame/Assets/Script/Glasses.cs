using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasses : MonoBehaviour
{
    
    private TextGlasses textGlasses;

    private void Start() 
    {
        textGlasses = GameObject.Find("Canvas").GetComponent<TextGlasses>();
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player") 
        {
            textGlasses.glasses += 1;
            Destroy(gameObject);
        }
    }
}
