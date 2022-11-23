using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    [SerializeField]float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
           
            transform.position -= Vector3.forward * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.forward * speed;
          
        }
    }
}
