using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using Random = System.Random;


public class ColorChange : MonoBehaviour
{
   //This script when placed on a game object will randomly update the material color of the object per frame//

   public void Update()
   {
      ChangeColor(Color.green);
   }

   public void ChangeColor(Color newColor)
   {
      Renderer renderer = GetComponent<Renderer>();

      if (renderer != null)
      {
         newColor = UnityEngine.Random.ColorHSV(); 
         renderer.material.color = newColor;
      }
      
      Debug.Log("The code has run :)");
   }
    
    
}

