using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    // when you press the plate - it activates the color change script //
    private void OnCollisionEnter(Collision other)
    {
      if (other.gameObject.CompareTag("Player"))
      { 
          RunChangeColor();
      }

      void RunChangeColor()
      {
          Collider collider = GetComponent<Collider>();
          ColorChange initiator;
          initiator = gameObject.AddComponent<ColorChange>();
          initiator.ChangeColor(Color.green);
                
          Debug.Log("Change color has run");

      }
    }
    
}
