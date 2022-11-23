using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float health= 3f;
    // Start is called before the first frame update


    void GetDamage(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            this.gameObject.SetActive(false); 
        }
    }
}
