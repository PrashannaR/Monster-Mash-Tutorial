using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{
    

    public void RestartControl(){
     
        SceneManager.LoadScene("Gameplay");

    }

    public void home(){
             SceneManager.LoadScene("MainMenu");
    }






}//class
