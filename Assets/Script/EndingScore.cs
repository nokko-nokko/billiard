using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PressFinish()
    {
        Debug.Log("Press to title");
        SceneManager.LoadScene("TitleScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
