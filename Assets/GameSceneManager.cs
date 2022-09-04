//Esto es para el boton y crean un empty y ponerle este script
//https://drive.google.com/drive/folders/1o1MtamPfRG1G1SvO_D3__VnRIE6f-Bk8 derecha 11:45

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToScene(string sceneName) //le pónes el nombre de la escena en la scene cuando le decis al boton que hacer
    {
        SceneManager.LoadScene(sceneName);
    }
}
