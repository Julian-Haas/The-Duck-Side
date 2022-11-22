using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    //spawn Point der Bullet
   [SerializeField] Transform Gun;
    //bullet Object 
    [SerializeField]GameObject Bullet;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        //abfragen ob Linke Maustaste gedrückt wurde
        if (Input.GetButton("Fire1"))
        {
            shoot(); 
        }   
    }

    private void shoot()
    {
        //spawnen der Bullet
        var bullet = Instantiate(Bullet, Gun.position, Gun.rotation);
        //bullet flug direction geben 
        bullet.GetComponent<Rigidbody>().AddForce(Gun.right*1000f, ForceMode.VelocityChange);
    }
}
