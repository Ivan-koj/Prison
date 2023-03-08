using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDestination : MonoBehaviour
{
   public int pivotPoint;

   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "npc")
      {
         if (pivotPoint == 3)
         {
            pivotPoint = 0;
         }
         if (pivotPoint == 2)
         {
            this.gameObject.transform.position= new Vector3(-0.26f,-0.037f,-7.47f);
            pivotPoint = 3;
         }
         if (pivotPoint == 1)
         {
            this.gameObject.transform.position= new Vector3(-3.62f,-0.037f,-11.8f);
            pivotPoint = 2;
         }
         if (pivotPoint == 0)
         {
            this.gameObject.transform.position= new Vector3(2.45f,-0.037f,-16.56f);
            pivotPoint = 1;
         }
        
      }
   }
}
