using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    // when you activate the pressure plate; it then activates the color changing script //
    private void OnCollisionEnter()
    {
        Collider collider = GetComponent<Collider>();
            
        //This code calls the changecolor function//
        ColorChange initiator;
        initiator = gameObject.AddComponent<ColorChange>();
        initiator.ChangeColor(Color.green);

    }
    
}
