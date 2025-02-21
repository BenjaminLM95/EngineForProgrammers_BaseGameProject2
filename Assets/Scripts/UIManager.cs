using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UIManager : MonoBehaviour
{
    public GameObject MainMenuUI;   
    public GameObject PausedUI;
    public GameObject OptionsUI;
    public GameObject playerUI;
    public GameObject ScoreUI; 

    public void EnableMainMenuUI()
    {
        DisableAllUI();
        MainMenuUI.gameObject.SetActive(true);
        Cursor.visible = true;

    }

    public void EnableGamePlay()
    {       
        DisableAllUI() ;
        playerUI.gameObject.SetActive(true);
        ScoreUI.gameObject.SetActive(true);
        Cursor.visible = false;

    }    

    public void EnablePause()
    {
        PausedUI.gameObject.SetActive(true);
        Cursor.visible = true;

    }

    public void EnableOptions() 
    {
        DisableAllUI();
        OptionsUI.gameObject.SetActive(true);   
    }

    public void DisablePause()
    {
        PausedUI.gameObject.SetActive(false);

    }

    public void DisableAllUI()
    {
        PausedUI.gameObject.SetActive(false);        
        MainMenuUI.gameObject.SetActive(false);
        OptionsUI.gameObject.SetActive(false); 
        playerUI.gameObject.SetActive(false);   
        ScoreUI.gameObject.SetActive(false);
    }
}
