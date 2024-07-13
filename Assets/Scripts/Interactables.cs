using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    // when you press the bell - it activates the color change script //
    private void OnMouseDown()
    {
        Collider collider = GetComponent<Collider>();
            
        //This code calls the changecolor function//
        ColorChange initiator;
        initiator = gameObject.AddComponent<ColorChange>();
        initiator.ChangeColor(Color.green);

    }
    
}
