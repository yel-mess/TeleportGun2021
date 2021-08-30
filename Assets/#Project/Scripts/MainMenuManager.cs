using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame() {
        //passer à la scène du jeux
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame() {
        Application.Quit();
    }
}
