using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kugelerst : MonoBehaviour {

    public int KugelReibung = 1;
    public GameObject bocciakugel;
    public Material KugelFarbe;
    public Material KugelFarbeG;
    public Renderer rend;
    public Vector3 forceG;
    public int timeCount = 0;
    public float v=1;
    private int count = 0;
    //erstellt eine Kugel 
    //nur für den einen Spieler
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && count < 4)
        {
            count++;
            WerfenDerKugel();
        }
        //if (timeCount > 120)
        //{
        //Invoke("GWirft", 1f);
        //timeCount = 0;
        //}
        //timeCount++;
    }
    void WerfenDerKugel()
    {
        GameObject kugel = Instantiate(bocciakugel, transform.position, Quaternion.identity);
        Vector3 force = Camera.main.transform.forward.normalized;
        force = force * v;
        kugel.GetComponent<Rigidbody>().AddForce(force);
        kugel.GetComponent<Rigidbody>().drag = KugelReibung;
        kugel.tag = "BocciaBall";
        rend = kugel.GetComponent<Renderer>();
        rend.enabled = true;
        rend.material = KugelFarbe;
        Invoke("GWirft", 0.5f);
    }

    private void GWirft()
    {
        GameObject kugelG = Instantiate(bocciakugel, new Vector3(3.5f, 4f, 1.5f), Quaternion.identity);
        Debug.Log("miep");
        //forceG = forceG * v;
        forceG = new Vector3(-1f, -0.3f, -0.2f) + new Vector3((Random.value-0.5f)*0.1f, (Random.value-0.5f)*0.1f, (Random.value-0.5f)*0.1f);
        kugelG.GetComponent<Rigidbody>().AddForce(forceG.normalized*v);
        kugelG.GetComponent<Rigidbody>().drag = KugelReibung;
        kugelG.tag = "BocciaBall";
        Debug.Log(forceG);
        rend = kugelG.GetComponent<Renderer>();
        rend.enabled = true;
        rend.material = KugelFarbeG;
        if (count > 3)
        {
            Invoke("WinAbfrage", 5f);
        }
    }

    private void WinAbfrage()
    {
        Renderer rendTwo = FindClosestEnemy().GetComponent<Renderer>();
        Debug.Log(rendTwo.material.name);
        if (rendTwo.material.name == "BocciaSpielerKugeln (Instance)")
        {
            //WIN
            Debug.Log("WIN");
        }
        else
        {
            //LOSE
            Debug.Log("LOSE");
        }
    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("BocciaBall");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

}