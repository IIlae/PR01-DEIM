using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    //Se declaran 2 variables
    public int days = 11;
    public int Ndays = 8;
    // Start is called before the first frame update
    void Start()
    {
        //Solo Ndays se cambia en el Start
        Ndays = 3;
        //Condición para no spamear la consola, se puede cambiar dentro de unity
        if (days != 0)
        {
            print("days: " + days + " Ndays: " + Ndays + " Less: " + (days + Ndays));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
