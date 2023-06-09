using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText = null;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        //scoreText.text = "Score" + GManager.instance.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
