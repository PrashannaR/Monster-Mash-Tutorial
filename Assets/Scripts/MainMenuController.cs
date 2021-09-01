using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //switches scene from main menu to gameplay
    public void PlayGame(){
        
        //shows the name of the button clicked & converts to integer
        
        int selectedPlayer = 
            int .Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = selectedPlayer;
        
        
        
          SceneManager.LoadScene("Gameplay");
    }







}//class
