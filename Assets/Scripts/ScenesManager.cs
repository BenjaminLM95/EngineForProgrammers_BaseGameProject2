using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public UIManager _uiManager = new UIManager();

    public void goToMainMenu() 
    {
        SceneManager.LoadScene("Main Menu"); 
    }

    public void goToGame() 
    {
        _uiManager.EnableGamePlay();
        SceneManager.LoadScene("Level1_AreaA");
        
    }

    public void ExitGame() 
    {
        Application.Quit(); 
    }
   


}
