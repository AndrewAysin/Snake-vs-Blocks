using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int StartHelthpoint = 1;


    void Update()
    {
        if (StartHelthpoint <= 0)
        {
            Die();    
        } 
    }
    void Die()
    {
        Destroy(gameObject);
        PlayerManager.isGameOver = true;
    }


    

}
