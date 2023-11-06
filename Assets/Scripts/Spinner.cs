using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 spinSpeed;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinSpeed);
    }
}

