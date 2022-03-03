using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeparateAI : MonoBehaviour
{
    GameObject[] enemies;
    public float stopDistance = 1.5f; //Change this later

    private void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy"); //Tag the ENEMIES AFTEEEER
    }

    void Update()
    {
        foreach(GameObject enemy in enemies)
        {
            if (enemy != gameObject)
            {
                float currentDistance = Vector3.Distance(enemy.transform.position, this.transform.position);

                if(currentDistance <= stopDistance)
                {
                    Vector3 movement = transform.position - enemy.transform.position;
                    transform.Translate(movement * Time.deltaTime);
                }
            }
        }
    }
}
