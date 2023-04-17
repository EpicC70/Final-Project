using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;
    //public float jumpforce = 10f;
    //public float gravityModifyer;
   // private Rigidbody playerRb; 
    // Start is called before the first frame update
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
       //Physics.gravity *= gravityModifyer;
    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        transform.position += moveDirection * speed;

    }

    //void FixedUpdate()
    //{
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
           // playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);

       // }
    //}
}
