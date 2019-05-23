using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
   public void ToGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void ToControls()
    {
        SceneManager.LoadScene("Controls");
    }
}
