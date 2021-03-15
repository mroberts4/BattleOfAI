using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options_Menu : MonoBehaviour
{
    public void BackButton()
    {
        int prevLvl = PlayerPrefs.GetInt("prevLvl");
        SceneManager.LoadScene(prevLvl);
       
    }

}
