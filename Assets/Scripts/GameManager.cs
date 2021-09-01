using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//singleton pattern helps to create one copy of game object
public class GameManager : MonoBehaviour
{

//creates a game manager -> instance
    public static GameManager instance;

//for player id (sort of)
    [SerializeField]
    private GameObject[] players;

//gets the sort of player id 
    private int _charIndex;
    public int CharIndex{
        get {
            return _charIndex;
        }
        set {
            _charIndex = value;
        }
    }
    
    //instance of MonoBehavious class
        private void Awake() {
        if(instance == null){

            //makes a copy of GameManager GameObject from MainMenu scene 
            instance = this;
            DontDestroyOnLoad(gameObject);

        }else{

            Destroy(gameObject);
        }
    }

//subscribes to the onLevelFinishedLoading event
private void OnEnable() {
    SceneManager.sceneLoaded += onLevelFinishedLoading;
}

//unsubscribes to the onLevelFinishedLoading event
private void OnDisable() {
    SceneManager.sceneLoaded -= onLevelFinishedLoading;
}
  void onLevelFinishedLoading(Scene scene, LoadSceneMode mode){

  }
}//class
