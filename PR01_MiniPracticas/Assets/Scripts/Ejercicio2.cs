using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour 
{
    //variable para parar el contador en el update, se puede cambiar en unity para que el contador no se ejecute
    public bool countCheck = true;
    //variable para el contador aleatorio, se puede alerar en unity para que no se ejecute
    public bool randomNums = true;
    // Start is called before the first frame update
    void Start()
    {
        //Variable para el número alatorio
        int randNumber;
        // variables para contar los números encontrados
        int lessThan10 = 0;
        int specialNum = 0;
        int failCount = 0;
        //bucle aleatorio, se para cuando llega a 9999, cuenta las veces que ha salido un número menos a 10 y las que ha salido el número 1234
        while (randomNums)
        {
            randNumber = Random.Range(1, 10000);
            if (randNumber < 10)
            {
                lessThan10++;
            }
            else if(randNumber == 1234)
            {
                specialNum++;
            }
            else if(randNumber == 9999)
            {
                randomNums = false;
                print("Ha habido " + (failCount + lessThan10 + specialNum) + " intentos, han habido " + lessThan10 + " menores a 10 y se ha encontrado el número especial " + specialNum + " veces.");
            }
            else 
            { 
                failCount++; 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //contador con condición
        if (countCheck)
        {
            print("Contando hasta 100: ");
            for (int x = 0; x <= 100; x++)
            {
                print(x);
            }
            //impide que el contador se repita en más frames
            countCheck = false;
        }
    }
}
