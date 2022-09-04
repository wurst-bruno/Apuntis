﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //engine para cambiar de escena
using UnityEngine.UI; //UI engine

//1 so por cada elemento
//https://github.com/jeronimosanchezperuga/TICL1L2-RepasoArraysABE

public class Apuntis : MonoBehaviour
{
    //1.Crear array publico de game objects
    public GameObject[] arrayDeMesas;


    void Start()
    {
        // 2.asignar todos los objetos taggeados como "Mesa" al array
        arrayDeMesas = GameObject.FindGameObjectsWithTag("Mesa");
    }

    void Update()
    {
        //Invocar la funcion al tocar una tecla.
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            DesactivateObjectsInArray();
            DestroyDestructible();
        }
    }

    // 3. crear una función que desactive todos los elementos del array 
    void DesactivateObjectsInArray()
    {
        for (int i = 0; i < arrayDeMesas.Length; i++)
        {
            arrayDeMesas[i].SetActive(false);
        }
    }

    //5.Crear una funcion que asigne todos los elementos del array el script mesa;
    //Establecer el valor de la variable "destructible" aleatoriamente.
    void AssignScriptMesaToArrayElement()
    {
        foreach (GameObject go in arrayDeMesas)
        {
            go.AddComponent<Mesa>();
            go.GetComponent<Mesa>().destructible = Random.Range(0, 2) == 0;  
           //Random.Range(0, 10); // Returns a number between 0 and 9
           //Random.Range(0f, 10f); // Returns a float between 0 and 10 

        }
    }


        //6. Crear una funcion que destruya el elemento del array que contenga un
    //script "Mesa" cuya variable booleana "Destructible" sea true. (Crear el script "Mesa")
    void DestroyDestructible()
    {
        foreach (GameObject go in arrayDeMesas)
        {
            if (go.GetComponent<Mesa>().destructible)
            {
                Destroy(go);
            }
        }
    }
}
