using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kugelerst2 : MonoBehaviour {

    public Renderer rend;
    public Color altColor = Color.blue;

    // Use this for initialization
    //genau wie Kugelerst allerdings für den zweiten Spieler
    //müssen damit eine Kugel gespawnt wird gestartet werden nachdem sie das getan haben sollten sie sich wieder closen
    //müssen noch verknüpft werden also alle Scripts sind noch sehr unabhängig voneinander
    //ihr könnten ein Hauptscript erstellen von dem ihr ein script nach dem anderen startet wenn ihr es braucht 
    void Start()
    {
        rend = GetComponent<Renderer>();
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3((float)4.09, (float)2.3, (float)0.28);
        sphere.transform.localScale = new Vector3((float)0.3, (float)0.3, (float)0.3);
        rend.material.color = altColor;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
