using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UIManager : MonoBehaviour
{
    public GameObject MainMenuUI;   
    public GameObject PausedUI;
    public GameObject InstructionsUI;
    public GameObject playerUI; 

    public void EnableMainMenuUI()
    {
        DisableAllUI();
        MainMenuUI.gameObject.SetActive(true);

    }

    public void EnableGamePlay()
    {       
        DisableAllUI() ;
        playerUI.gameObject.SetActive(true);

    }

    public void EnableInstruction() 
    {
        PausedUI.gameObject.SetActive(false);
        MainMenuUI.gameObject.SetActive(false);
        InstructionsUI.gameObject.SetActive(true);        
    }

    public void EnablePause()
    {
        PausedUI.gameObject.SetActive(true);

    }

    public void DisablePause()
    {
        PausedUI.gameObject.SetActive(false);

    }

    public void DisableAllUI()
    {
        PausedUI.gameObject.SetActive(false);        
        MainMenuUI.gameObject.SetActive(false);
        InstructionsUI.gameObject.SetActive(false); 
        playerUI.gameObject.SetActive(false);   
    }
}
