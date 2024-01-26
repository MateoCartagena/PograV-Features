using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject VidaPanel;
    public GameObject Pp;


    void Start()
    {
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update(){
         if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Parado");
            Pp.SetActive(false);
            Pause();
        }
    }

    public void Pause()
    {
        VidaPanel.SetActive(false);
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
