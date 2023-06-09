using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

   public GameObject scoreObj = null;
   //int finalNum = Orbit.onOrbitPlanetNum;

    // Start is called before the first frame update
    void Start()
    {
       Text scoreText = scoreObj.GetComponent<Text>();
       // scoreText.text = "GAMEOVER... \n 軌道に乗った惑星："+ finalNum + "個";
       scoreText.text = "0000";
        //Debug.Log(finalNum); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
