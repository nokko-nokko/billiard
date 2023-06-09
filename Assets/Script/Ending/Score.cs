using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;  
    int finalNum = Orbit.onOrbitPlanetNum;
    
     // Start is called before the first frame update
    void Start()
    {
        Debug.Log(7-finalNum);
        int remain = 7-finalNum;
        //scoreText = GetComponent<Text>();
       scoreText.text = "GAMEOVER... \n \n   " + remain + " planets remain";
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
