using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseGame : MonoBehaviour {

    //Zum Beenden des Programms 
    //momentan an Button 1 in mainmenu geknüpft aber lässt sich überall bei trigger einsetzen
        public void doquit()
    {
        Debug.Log("has quit the game");
        Application.Quit();
    }
    }
