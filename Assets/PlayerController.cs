using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float moveSpeed;
    
    
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
      
    }
    void MovePlayer(){
         float moveX=Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0f, moveZ);
    }
}
