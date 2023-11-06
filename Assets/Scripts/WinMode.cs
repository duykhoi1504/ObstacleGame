using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMode : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
            this.gameObject.GetComponent<MeshRenderer>().material.color=Color.red;
    }

    private void OnTriggerExit(Collider other) {
               this.gameObject.GetComponent<MeshRenderer>().material.color=Color.black;

    }
   
    
}
