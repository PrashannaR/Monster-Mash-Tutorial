using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //switches scene from main menu to gameplay
    public void PlayGame(){
        SceneManager.LoadScene("Gameplay");
    }







}//class
