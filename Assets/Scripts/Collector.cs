using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) {
       if (other.CompareTag("Enemy")){
           Destroy(other.gameObject);
       }

       if(other.gameObject.CompareTag("Player")){
           Destroy(other.gameObject);
           Debug.Log("Player is deleted");
       }
   }
}
