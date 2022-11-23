using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Transform[] WayPoints;
    [SerializeField] float speed;
    bool attackPlayer = false;
    [SerializeField]Transform Player; 
    int index=0;
    bool isOnPoint = false ;
    Vector3 Distance;
    // Start is called before the first frame update

  
    // Update is called once per frame
    void Update()
    {
        Distance = WayPoints[index].position - transform.position; 
        if(transform.position != WayPoints[index].position)
        {

            transform.position = Vector3.MoveTowards(transform.position, WayPoints[index].position, speed); 
  
            if (this.transform.position == WayPoints[index].transform.position)
            {
                isOnPoint = true;
                GetPos(); 
            }
        }

        if (Vector3.Distance(this.transform.position, Player.position) <= 10f)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.position, speed);
        }
    }

    void GetPos()
    {

        switch (index)
        {

            case 0:
                index = 1;
                break;
            case 1:
                index = 0;
                break;
                isOnPoint = false; 

        }

        moveToPos(); 

    }

    void moveToPos()
    {
        transform.RotateAround(transform.position, Vector3.up, -180f); 
        if (this.transform.position != WayPoints[index].transform.position && !isOnPoint)
        {

            transform.position = Vector3.MoveTowards(transform.position, WayPoints[index].position, speed);
            if (this.transform.position == WayPoints[index].transform.position)
            {
                isOnPoint = true;
                GetPos();
            }
        }
    }

}

