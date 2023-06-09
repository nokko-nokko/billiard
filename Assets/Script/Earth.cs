using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    [SerializeField] GameObject earth = null;
    [SerializeField] float power = 20f;
    [SerializeField] Transform arrow = null;
    [SerializeField] List<Planet> balllist = new List<Planet>();
    [SerializeField] List<BlackHole> holelist = new List<BlackHole>();
    Vector3 mousePosition = new Vector3();
    Rigidbody earthRigid = null;
    Vector3 earthDefaultPosition = new Vector3();

    
    // Start is called before the first frame update
    void Start()
    {
        earthRigid = earth.GetComponent<Rigidbody>();
        earthDefaultPosition = earth.transform.localPosition;
       arrow.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(earth.activeSelf == true)
        {
          if(Input.GetMouseButtonDown(0) == true)
          {
            mousePosition = Input.mousePosition;
            arrow.gameObject.SetActive(true);
            Debug.Log("クリック開始");

          }
         
         if(Input.GetMouseButton(0) ==true )
         {
            Vector3 position = Input.mousePosition;
            
            Vector3 def = mousePosition - position;
            float rad = Mathf.Atan2(def.x, def.y);
            float angle = rad* Mathf.Rad2Deg;
            Vector3 rot = new Vector3(0, angle, 0);
            Quaternion qua = Quaternion.Euler(rot);

            arrow.localRotation = qua;
            arrow.transform.position = earth.transform.position;
         }

         if(Input.GetMouseButtonUp(0) ==true)
         {
            Vector3 upPosition = Input.mousePosition;

            Vector3 def = mousePosition - upPosition;
            Vector3 add = new Vector3(def.x, 0, def.y);

            earthRigid.AddForce(add*power);
            arrow.gameObject.SetActive(false);
            Debug.Log("クリック終了");
         }
            
        }
     }
       

    public void OnResetButtonClicked()
    {
        earth.SetActive(true);
        earthRigid.velocity = Vector3.zero;
        earthRigid.angularVelocity = Vector3.zero;
        earth.transform.localPosition = earthDefaultPosition;

        foreach(Planet ball in balllist)
        {
            ball.Reset();
        }

        /*foreach(BlackHole cylinder←？ in holelist)
        {
            cylinder.Reset();
        }*/

    }
    }
