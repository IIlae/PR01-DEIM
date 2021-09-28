using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio3 : MonoBehaviour
{
    public Text timer;
    private float intervalo = 1.0f;
    private int[] timeNums = new int[3] {0, 0, 0};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        intervalo -= Time.deltaTime;
        if (intervalo < 0)
        {
            intervalo = 1;
            timeNums[0]++;
            if (timeNums[0] > 59)
            {
                timeNums[0] = 0;
                timeNums[1]++;
                if (timeNums[1] > 59)
                {
                    timeNums[1] = 0;
                    timeNums[2]++;
                }
            }
            print(timeNums[2] + ":" + timeNums[1] + ":" + timeNums[0]);
        }
    }
}
