using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {

        if(other.gameObject.tag!="Player")return;
        this.gameObject.tag="Hit";
        this.GetComponent<MeshRenderer>().material.color=Color.black;
        // this.GetComponent<MeshRenderer>().materials.GetValue(2)
      
        
    }
}
