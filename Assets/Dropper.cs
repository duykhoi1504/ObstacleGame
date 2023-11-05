using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer renderer;
    float countTime = 0;
    Rigidbody rigi;
    [SerializeField] Vector3 dropperPos;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigi = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigi.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        if (countTime < 3f)
            return;
        renderer.enabled = true;
        rigi.useGravity = true;
        if (countTime > 6f)
        {
            this.transform.position = dropperPos;
            renderer.enabled = false;
            rigi.useGravity = false;
            countTime = 0f;
        }

    }
}
