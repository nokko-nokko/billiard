using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Orbit : MonoBehaviour
{
    [SerializeField] GameObject centerObj;
    [SerializeField]float angle = 50;
   // [SerializeField]int waitFrame;
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("入った惑星:"+ other.gameObject.name);       
    }

    void OnTriggerStay(Collider other)
    {
        
       if(other.gameObject.name != "Earth")
       {
        //速度を０に
        other.gameObject.GetComponent<Rigidbody>();
        other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
       
        //RotateAround(中心の場所、軸、回転角度)
         other.gameObject.transform.RotateAround (centerObj.transform.position, Vector3.up, angle * Time.deltaTime); 
        /* ↓　衝突をなくしたいけどColliderをoffにするとOnTriggerが機能しない
         other.gameObject.GetComponent<SphereCollider>();
        other.gameObject.GetComponent<Collider>().enabled = false; */
       }

       else
       {//Earthなら消えて、エンディングシーンへ
        other.gameObject.SetActive(false);

        //フェードか数秒待ちをいれたい
        void Awake()
        {
            StartCoroutine(LoadEnding());
        }
        IEnumerator LoadEnding()
        {
           yield return null;
        }
           SceneManager.LoadScene("Ending");  
        
             
       }
       
    }
}

    

