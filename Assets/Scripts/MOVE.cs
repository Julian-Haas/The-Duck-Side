using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{

    [SerializeField]float speed = 1f;
    [SerializeField]float jump = 3f;
    Vector3 moveRight;
    Vector3 moveLeft;
    bool isGrounded = true; 
    // Start is called before the first frame update
    void Start()
    {
        moveRight = new Vector3(0, 0, 0);
        moveLeft = new Vector3(0, 180, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        //laufen
        if (Input.GetKey(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(moveRight);
            transform.position += Vector3.right * speed; 
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= Vector3.right * speed;
            transform.localRotation = Quaternion.Euler(moveLeft);
        }
        //springen
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            isGrounded = false; 
            transform.position += Vector3.up * jump; 
        }
    }
    //groundcheck
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true; 
    }
}
