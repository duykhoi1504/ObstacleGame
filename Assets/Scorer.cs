using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update
    int hits=0;
    private void OnCollisionEnter(Collision other) {
        hits+=1;
        Debug.Log("diem cua ban "+hits);
    }
}
