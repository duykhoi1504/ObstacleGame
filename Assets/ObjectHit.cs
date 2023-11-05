using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("bump ");
        Debug.Log(other.gameObject.name);
        this.GetComponent<MeshRenderer>().material.color=Color.black;
        // this.GetComponent<MeshRenderer>().materials.GetValue(2)
        Debug.Log(Time.time);
        
    }
}
