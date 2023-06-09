using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
   // [SerializeField] GameObject centerObj;
   float angle = 50;
    Vector3 defaultPosition = new Vector3();

    Rigidbody rigid = null;
    

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        defaultPosition = this.transform.localPosition;
    }

    
    void Update()
    {
        transform.Rotate(Vector3.up, angle*Time.deltaTime);
    }
   

    // Update is called once per frame
    public void Reset()
    {
        gameObject.SetActive(true);
        rigid.velocity = Vector3.zero;
        rigid.angularVelocity = Vector3.zero;
        this.transform.localPosition = defaultPosition;
        
    }
}
