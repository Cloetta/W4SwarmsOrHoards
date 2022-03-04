using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    private PlayerMovement playerScript;
    private MouseMove mouseScript;

    public GameObject inGameMenu;

    public bool menuOn = false;


    private void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        mouseScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseMove>();
    }


    private void Update()
    {
        //Call the player script so we can disable it temporarily while the inventory is open
        

        //Esc to open the menu in game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuOn == false)
            {
                inGameMenu.SetActive(true);
                playerScript.enabled = false;
                mouseScript.enabled = false;
                Time.timeScale = 0f; //Game is paused while the inventory is open
                menuOn = true;
                Cursor.lockState = CursorLockMode.None;
                //FindObjectOfType<AudioSystem>().Play("MenuClick"); //Feedbackfor opening the menu
            }
            else
            {
                inGameMenu.SetActive(false);
                playerScript.enabled = true;
                mouseScript.enabled = true;
                Time.timeScale = 1f;
                menuOn = false;
                Cursor.lockState = CursorLockMode.Locked;
                //FindObjectOfType<AudioSystem>().Play("Remove"); //Feedback for closing the menu
            }

        }

    }



}
