using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayerAI : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    public float stopDistance = 1.5f; //Change later

    private float distance;
    public float angle = 360f; //needs to be public for the editor script

    public float moveSpeed = 5;

    public float radius;

    void Update()
    {
        Vector3 directionVector = (transform.position - player.transform.position).normalized;

        //Vector3 directionVector = transform.position - player.transform.position;
        // note: the following only looks at x-z axis, i.e. the 20 distance ignoring the height
        // distance = Mathf.Sqrt(Mathf.Pow(directionVector.x, 2) ] Mathf.Pow(directionVector.z, 2));

        distance = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log("Distance: " + distance);

        float dotProduct = Vector3.Dot(directionVector, transform.forward);


          //check if i need the dot product here
        if (/*dotProduct > -0.95f || */distance <= 20f)
        {
            Debug.Log(dotProduct + " : in field of view. Distance - " + distance);

            Vector3 movement = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
            transform.position = movement;


                
        }
        else
        {
            Debug.Log(dotProduct + " : out of sight. Distance - " + distance);
        }

        //if (Vector3.Distance(player.position, transform.position) >= stopDistance)
        //{
        //    Vector3 movement = player.position - transform.position;
        //    transform.Translate(movement * Time.deltaTime);
        //}

    }



    public Vector3 FromVector
    {
        get
        {
            float leftAngle = -angle / 2;
            leftAngle += transform.eulerAngles.y;
            return new Vector3(Mathf.Sin(leftAngle * Mathf.Deg2Rad), 0, Mathf.Cos(leftAngle * Mathf.Deg2Rad));
        }
    }

}
