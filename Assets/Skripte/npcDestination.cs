using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDestination : MonoBehaviour
{
   public int pivotPoint;
   public GameObject destination;

   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "npc")
      {
         if (pivotPoint == 3)
         {
            pivotPoint = 1;
         }
         if (pivotPoint == 2)
         {
            destination.gameObject.transform.position= new Vector3(-183.7338f,17.302f,0.724f);
            pivotPoint = 3;
         }
         if (pivotPoint == 1)
         {
            destination.gameObject.transform.position= new Vector3(-165.15f,19.69f,1f);
            pivotPoint = 2;
         }
         if (pivotPoint == 0)
         {
            destination.gameObject.transform.position= new Vector3(-165.15f,19.69f,9.3f);
            pivotPoint = 1;
         }
        
      }
   }
}
