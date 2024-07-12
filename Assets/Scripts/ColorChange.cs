using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using Random = System.Random;


public class ColorChange : MonoBehaviour
{
   // This script when placed on a game object will randomly update the material color and light color of the object per frame//
   public void Update()
   {
      ChangeColor(newColor: Color.red);
   }
   public void ChangeColor(Color newColor)
   {
      Renderer renderer = GetComponent<Renderer>();
      Light light = GetComponent<Light>();

      newColor = UnityEngine.Random.ColorHSV();

      renderer.material.color = newColor;
      light.color = newColor;
      

      //Debug.Log("The code has run :)");
   }
    
    
}

