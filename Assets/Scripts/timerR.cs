using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class timerR : MonoBehaviour
{
    public static timerR instanciar;
    public Text Crono;
    private TimeSpan tiempoCrono;
    private bool timerBool;
    private float tiempoTrans;

    private void Awake()
    {
        instanciar = this;
    }


    void Start()
    {
        Crono.text = "tiempo 00:00:00";
        timerBool = false;
        timerR.instanciar.iniciarTiempo();

    }

    public void iniciarTiempo()
    {
        timerBool = true;
        tiempoTrans = 0F;

        StartCoroutine(ActUpdate());  
    }

    public void FinTiempo()
    {
        timerBool = false;
    }

    private IEnumerator ActUpdate()
    {
        while (timerBool)
        {
            tiempoTrans += Time.deltaTime;
            tiempoCrono = TimeSpan.FromSeconds(tiempoTrans);
            string tiempoCronoStr = tiempoCrono.ToString("mm':'ss':'fff");
            Crono.text = tiempoCronoStr;

            yield return null; 
        }
    }

}
