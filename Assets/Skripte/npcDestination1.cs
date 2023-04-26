using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDestination1 : MonoBehaviour
{
   public float BrojPivot;
   public int pivotPoint;
   public GameObject destination;
   public float pivot0x,pivot0y,pivot0z,pivot1x,pivot1y,pivot1z,pivot2x,pivot2y,pivot2z,pivot3x,pivot3y,pivot3z;

   private void OnTriggerEnter(Collider other)
   {
      if (other.tag == "npc")
      {
         if (BrojPivot == 1)
         {
            Tri();
         }

         if (BrojPivot == 2)
         {
            Cetiri();
         }
        
      }
   }

   public void Tri()
   {
      if (pivotPoint == 3)
      {
         pivotPoint = 0;
      }
      if (pivotPoint == 2)
      {
         destination.gameObject.transform.position= new Vector3(pivot2x,pivot2y,pivot2z);
         pivotPoint = 3;
      }
      if (pivotPoint == 1)
      {
         destination.gameObject.transform.position= new Vector3(pivot1x,pivot1y,pivot1z);
         pivotPoint = 2;
      }
      if (pivotPoint == 0)
      {
         destination.gameObject.transform.position= new Vector3(pivot0x,pivot0y,pivot0z);
         pivotPoint = 1;
      }
        
   }
   public void Cetiri()
   {
      if (pivotPoint == 4)
      {
         pivotPoint = 0;
      }
      if (pivotPoint == 3)
      {
         destination.gameObject.transform.position= new Vector3(pivot3x,pivot3y,pivot3z);
         pivotPoint = 4;
      }
      if (pivotPoint == 2)
      {
         destination.gameObject.transform.position= new Vector3(pivot2x,pivot2y,pivot2z);
         pivotPoint = 3;
      }
      if (pivotPoint == 1)
      {
         destination.gameObject.transform.position= new Vector3(pivot1x,pivot1y,pivot1z);
         pivotPoint = 2;
      }
      if (pivotPoint == 0)
      {
         destination.gameObject.transform.position= new Vector3(pivot0x,pivot0y,pivot0z);
         pivotPoint = 1;
      }

        
   }
}
