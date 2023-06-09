using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    [SerializeField] GameObject blackHole_1 = null;
    [SerializeField] GameObject blackHole_2 = null;
   // Vector3 HolePosition = new Vector3();
    
    // Start is called before the first frame update
    void Start()
    {
       // HolePosition = blackHole.transform.localPosition;
        blackHole_1.gameObject.SetActive(false);
        blackHole_2.gameObject.SetActive(false);
    }


   
    // Update is called once per frame
    void Update()
    {
        if ( blackHole_1.activeSelf == false)
        {
   
        if(Input.GetMouseButtonDown(1) == true)
        {
            Debug.Log("クリック開始");
            //↓これをやると画面に映らなくなる、、座標の問題？
           //HolePosition = Input.mousePosition;
            //blackHole.transform.localPosition = HolePosition;
            
        }

        if(Input.GetMouseButtonUp(1) == true)
        {
            blackHole_1.gameObject.SetActive(true);
            Debug.Log("ブラックホール1出現");
        }
        }
        else{
             if(Input.GetMouseButtonDown(1) == true)
        {
            Debug.Log("クリック開始");
            //↓これをやると画面に映らなくなる、、座標の問題？
           //HolePosition = Input.mousePosition;
            //blackHole.transform.localPosition = HolePosition;
            
        }

        if(Input.GetMouseButtonUp(1) == true)
        {
            blackHole_2.gameObject.SetActive(true);
            Debug.Log("ブラックホール2出現");
        }

        }

    }

    public void Reset()
    {
        gameObject.SetActive(false);
    }

    

}
