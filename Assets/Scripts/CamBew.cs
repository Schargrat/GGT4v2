using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamBew : MonoBehaviour {



    void Start()
    {

    }
    //Bewegt die main Kamera mit der Maus
      void Update() {   
        Camera.main.transform.RotateAround(Camera.main.transform.position,2* Camera.main.transform.right, -Input.GetAxis("Mouse Y"));
        Camera.main.transform.RotateAround(Camera.main.transform.position,2* Vector3.up, Input.GetAxis("Mouse X"));

        Cursor.lockState = CursorLockMode.Locked;

    }
}
