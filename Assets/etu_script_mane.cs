using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class etu_script_mane : MonoBehaviour
{
    public string premierNiveau;
    public Button debuter;  
    public Button quitter;

    public void lorsDebuter()
    {
        SceneManager.LoadScene(premierNiveau);
    }

    public void lorsQuitter()
    {
        //Application.Quit();
        Debug.Log("quitting");
    }

    public void lorsPause()
    {
        // pour accelerer ou decelerer
        if (Time.timeScale > 0.5f)
        {
            Time.timeScale = 0;
            debuter.interactable = false;
            quitter.interactable = false;
        }
        else
        {
            Time.timeScale = 1.0f;
            debuter.interactable = true;
            quitter.interactable = true;

        }
        Debug.Log("quitting");
    }
}
