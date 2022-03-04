using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuosDamage : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<BugsCombat>().TakeDamage();
        }

        Debug.Log("Collided Object: " + other.name);
       
    }
}
