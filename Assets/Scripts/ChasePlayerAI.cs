using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayerAI : MonoBehaviour
{
    public Transform player;
    public float stopDistance = 1.5f; //Change later


    void Update()
    {
        if(Vector3.Distance(player.position, transform.position) >= stopDistance)
        {
            Vector3 movement = player.position - transform.position;
            transform.Translate(movement * Time.deltaTime);
        }
        
    }
}
