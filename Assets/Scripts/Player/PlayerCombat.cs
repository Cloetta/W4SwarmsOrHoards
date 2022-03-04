using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{

    public Text txtHealth;
    public Text txtMedKits;
    public float totalTime;
    public float healthPoints;
    public int medKits;

    public bool isDead;
    
    public 
    
    // Start is called before the first frame update
    void Start()
    {
        totalTime = 0;
        healthPoints = 100;
        medKits = 10;
        Time.timeScale = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        //For debugging purposes only
        if (Input.GetKeyDown(KeyCode.Q) && medKits > 0 && healthPoints < 100)
        {
            healthPoints = 100;
            
            medKits -= 1;

            txtHealth.text = "Health: " + healthPoints;
            txtMedKits.text = "MedKits: " + medKits;
        }


        if (healthPoints <= 0)
        {
            isDead = true;
        }

    }

    public void TakeDamage()
    {
        //storing time passed into a float variable
        totalTime += Time.deltaTime;

        if (totalTime > 1)
        {
            //damaging enemy hp
            healthPoints -= 5;
            Debug.Log("playerHP:" + healthPoints + ", totalTime: " + totalTime);

            txtHealth.text = "Health: " + healthPoints;

            totalTime = 0;
        }
    }
}
