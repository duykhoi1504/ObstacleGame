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
    [SerializeField] float randomTime;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigi = GetComponent<Rigidbody>();
        dropperPos=this.transform.position;
        renderer.enabled = false;
        rigi.useGravity = false;
        randomTime=Random.Range(1,4);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("thoi gian random "+randomTime);
        countTime += Time.deltaTime;
        if (countTime < randomTime)
            return;
        renderer.enabled = true;
        rigi.useGravity = true;
        if (countTime > randomTime+2f)
        {
            this.transform.position = dropperPos;
            renderer.enabled = false;
            rigi.useGravity = false;
            countTime = 0f;
            randomTime=Random.Range(1,4);
        
        }

    }
}
