using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ChangeToStoryScreen(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
    public void QuitGame()
    {
       
            Application.Quit();
       
      

    }

    public void BackToMenu (int SceneIndex)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ChangeToOptionsScreen(int SceneIndex)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
