using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    [SerializeField] private AudioSource AudioSource;
    [SerializeField] private AudioClip AudioClip1;
    [SerializeField] private AudioClip AudioClip2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if(col.gameObject.name != "Cube"){
            if(col.gameObject.name == "Cube (2)" || col.gameObject.name == "Cube (3)" || col.gameObject.name == "Cube(4)" || col.gameObject.name == "Cube (5)"){
                AudioSource.PlayClipAtPoint(AudioClip1, transform.position);
            } else {
                AudioSource.PlayClipAtPoint(AudioClip2, transform.position);
            }
        }
    }
}
