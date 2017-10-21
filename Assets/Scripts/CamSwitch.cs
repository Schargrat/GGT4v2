using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

    public Camera Camerak;
    public Camera Camerat;


    // Use this for initialization
    // Wechselt die aktive Kamera bei Boccia wenn es gestartet wird aber schließt sich nach dieser aktion wieder
    void Start () {
        if (Camerak.enabled == true)
        {
            Camerak.enabled = false;
            Camerat.enabled = true;
        } else
        {
            Camerak.enabled = true;
            Camerat.enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
