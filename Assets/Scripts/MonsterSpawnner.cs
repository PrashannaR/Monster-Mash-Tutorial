using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;
    private GameObject spawnnedMonster;
    [SerializeField]
    private Transform leftPos, rightPos; //2 GameObjects Right and Left are assigned in the Unity to these transform values

    private int randomIndex;
    private int randomSide;
    


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters(){

     while (true){
            yield return new WaitForSeconds(Random.Range(1,5)); //spawns a new monster between every 1 & 5 sec

      //sets the index value to the length of monsterReference Array and 
     //randomizes them for spawnning 
        randomIndex = Random.Range(0, monsterReference.Length); 
        randomSide = Random.Range(0,2);         

        spawnnedMonster = Instantiate(monsterReference[randomIndex]); //sets the monsterReference index value to the randomIndex value

        //left side
        if(randomSide == 0){
            spawnnedMonster.transform.position = leftPos.position;
            spawnnedMonster.GetComponent<Monster>().speed = Random.Range(4,10); //sets the speed value between 4 & 10

        }else{
            //right side
            spawnnedMonster.transform.position = rightPos.position;
            spawnnedMonster.GetComponent<Monster>().speed = -Random.Range(4,10);

            //flips the sprite
            spawnnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
     }//while loop, this will spawn multiple monsters 
    }
    




}//class
