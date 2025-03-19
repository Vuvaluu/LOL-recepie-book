using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

   public void ChooseGame()
    {
        SceneManager.LoadScene("Choose Game");
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Opcion1()
    {
        SceneManager.LoadScene("PlayEpics");
    }

    public void Opcion2()
    {
        SceneManager.LoadScene("LegendaryItems");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
