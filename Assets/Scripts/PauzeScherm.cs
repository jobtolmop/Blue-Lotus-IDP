using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauzeScherm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.GetChild(2).gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Resume()
    {
        transform.GetChild(2).gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene("BeginScherm");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        SceneManager.LoadScene("LogoStart");
        Time.timeScale = 1f;
    }

}
