using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugsCombat : MonoBehaviour
{

    public float totalTime = 0;
    public PlayerCombat player;

    public float healthPoints = 40;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCombat>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints <= 0)
        {
            Destroy(gameObject, 0f);
        }
    }

    public void TakeDamage()
    {
        //move to damaging self to enemy script
        totalTime += Time.deltaTime;

        if (totalTime > 1)
        {
            //damaging enemy hp
            healthPoints -= 5;
            Debug.Log("EnemyHp:" + healthPoints + ", totalTime: " + totalTime);

            totalTime = 0;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            player.TakeDamage();
        }
    }

}
