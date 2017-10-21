using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewGame : MonoBehaviour
{
    //startet mainscene und beendet mainmenu
    //mit der methode könntet ihr auch andere scenen startet allerdings 
    //müssen dann die namen ersetzt werde und auch die scenen ins bundle hinzugefügt werden
    public void Loadmain()
    {
        SceneManager.LoadScene(sceneName: "mainscene", mode: LoadSceneMode.Single);
    }

}
