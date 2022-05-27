using System.Globalization;
using System.ComponentModel;
using System.Timers;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text UItexto;
    private int contador=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UItexto.text=Time.time.ToString();
        //print(Time.time);
    }

/*    private void Awake(){
        InvokeRepeating("Cronometro" , 0f, 1f);
    }
    void Cronometro(){
        contador++;
        UItexto.text= contador.ToString();
    }*/
}
