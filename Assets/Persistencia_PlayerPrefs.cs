using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistencia_PlayerPrefs : MonoBehaviour
{
    //resumen del repo https://drive.google.com/drive/folders/1o1MtamPfRG1G1SvO_D3__VnRIE6f-Bk8 video del medio a las 14.14
    public string nombre;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("nombreAlmacenado", nombre); //Playerprefs.SetFloat/Int/String(elnombre, nombre variable)
        
        //para mostrar ese dato almacenado en otra scene:
        Debug.Log(PlayerPrefs.GetString("nombreAlmacenado")); //tambien en el start

    }

    // Crear los emptys en la escena y asignarle los respectivos scripts (https://drive.google.com/drive/folders/1o1MtamPfRG1G1SvO_D3__VnRIE6f-Bk8 video del medio minuto 8.10)


    // Update is called once per frame
    void Update()
    {

    }
}