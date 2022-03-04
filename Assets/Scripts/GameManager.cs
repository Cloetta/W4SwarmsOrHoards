using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    GameObject[] enemies;

    PlayerCombat player;



    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCombat>();
    }

    // Update is called once per frame
    void Update()
    {

        foreach (GameObject enemy in enemies)
        {
            if (enemy == null)
            {
                enemies = GameObject.FindGameObjectsWithTag("Enemy");
            }
        }

        if (enemies.Length == 0)
        {
            LoadWin();
        }

        if (player.isDead)
        {

            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("GameOver");
        }

        
    }

    public void LoadWin()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Win");
    }
}
