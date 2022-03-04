using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonShooting : MonoBehaviour
{
    //public float damage = 10f;
    //public float range = 10f;

    public Collider poisonCollider;

    public ParticleSystem poison;

    List<ParticleCollisionEvent> collisionEvents;

    //public Camera fpsCam;


    private void Start()
    {
        poison.Stop();

        poisonCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootPoison();
            poisonCollider.enabled = true;
        }
        else if(Input.GetButtonUp("Fire1"))
        {
            poison.Stop();
            poisonCollider.enabled = false;
        }
        
        void ShootPoison()
        {
            //RaycastHit hit;

            //if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            //{
            //Debug.Log(hit.transform.name);


            // }

            // Debug.DrawLine(fpsCam.transform.position, hit.point, Color.magenta, 10f);

            poison.Play();
        }




    }


}
