using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

   public void SeeEpicItems()
   {
    SceneManager.LoadScene("EpicItems");
   }

   public void SeeLegendaryItems()
   {
    SceneManager.LoadScene("LegendaryItems");
   }

   public void PlayEpicItems()
   {
    SceneManager.LoadScene("PlayEpics");
   }

   public void PlayLegendaryItems()
   {
    SceneManager.LoadScene("PlayLegendarys");   
   }

   public void MainMenu()
   {
    SceneManager.LoadScene("Menu");
   }
}
