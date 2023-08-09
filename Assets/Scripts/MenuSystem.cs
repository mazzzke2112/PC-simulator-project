using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MenuSystem : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Room");
    }
    
    public void SettingsButton()
    {
        SceneManager.LoadScene("Settings");
    }
    
    public void ExitButton()
    {
        Application.Quit();
    }
}