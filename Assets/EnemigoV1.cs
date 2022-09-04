using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoV1 : MonoBehaviour
{
    public bool defeated = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown() //https://drive.google.com/drive/folders/1o1MtamPfRG1G1SvO_D3__VnRIE6f-Bk8 de la izq minuto 4.30
    {
        defeated = true;
        GetComponent<MeshRenderer>().enabled = false; //Desactiva el MR
        GetComponent<Collider>().enabled = false; //Desactiva el Collider, no importa cual(cube, circle, etc) podes asignar todo eso a cada elemtno no importa forma ni nada.

    }
}