using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    [SerializeField] float angle = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, angle *Time.deltaTime);
    }
     void OnTriggerEnter(Collider other)
    {
        Debug.Log("落ちた惑星："+ other.gameObject.name);
       if(other.gameObject.name != "Earth")
        {
            other.gameObject.SetActive(false);
        }

    }
}
