using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://github.com/jeronimosanchezperuga/TICL1L2-RepasoArraysABE/blob/main/Assets/Scripts/ManipularObjetos.cs

public class ManipularObjetos : MonoBehaviour
{
    //1.Crear array publico de game objects
    [SerializeField] GameObject[] sillas;

    // Start is called before the first frame update
    void Start()
    {
        // 2.asignar todos los objetos taggeados como "silla" al array
        sillas = GameObject.FindGameObjectsWithTag("Silla");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            //DesactivarElementosDelArray();
            AgregarRBAElementosDelArray();
            AgregarColliderAElementosDelArray();
        }
    }

    void DesactivarElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++)
        {
            sillas[i].SetActive(false); //Las desactiva del todo
        }
    }

    void AgregarRBAElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++) //Con el for pasas por cada elemtno del array.
        {
            sillas[i].AddComponent<Rigidbody>(); //le agrega RB a cada elemento del array
        }
    }

    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < sillas.Length; i++)
        {
            sillas[i].AddComponent<BoxCollider>(); //agrega BC
        }
    }


}