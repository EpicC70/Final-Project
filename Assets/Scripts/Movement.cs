using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 1;
    public float jumpForce;
    public float gravityModifyer;
    public bool freeze;

    //Vector3 moveDirection;
    //Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifyer;
    }
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        transform.position += moveDirection * speed *Time.deltaTime;

       if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }

       if(freeze)
        {
            playerRb.velocity = Vector3.zero;
        }

        //moveDirection = new Vector3(moveX, moveY, moveZ).normalized;
        //mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

}



   
