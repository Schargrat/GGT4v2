using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kugelerst : MonoBehaviour {

    public GameObject bocciakugel;
    public float v=1;
    private int count = 0;
    // Use this for initialization
    //erstellt eine Kugel auf einer bestimmten Position mit den Eigenschaften eines festen Körpers also Kollider, rigitbody etc.
    //nur für den einen Spieler
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (count == 4)
        {
            
        }
		if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
            werfenderkugel();
        }
	}
    void werfenderkugel()
    {
        GameObject kugel = Instantiate(bocciakugel, transform.position, Quaternion.identity);
        Vector3 force = Camera.main.transform.forward.normalized;
        force = force * v;
        kugel.GetComponent<Rigidbody>().AddForce(force);
    }
}
