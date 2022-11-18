using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   
   // Private Variables
   private float speed = 5.0f;
   private float turnSpeed = 25.0f;
   private float horizontalInput;
   private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
       // This is where we get player input
       horizontalInput=Input.GetAxis("Horizontal");
       forwardInput =Input.GetAxis("Vertical");
        // We move the Player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
     
        }
        
       
}
