using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorDeTiempo : MonoBehaviour
{
    public int tiempoDeContador;
    public TextMeshProUGUI cronometroTP;

    void Start()
    {
        StartCoroutine(Cronometro());
    }
    IEnumerator Cronometro()
    {
        while(tiempoDeContador >= 0)
        {
            yield return new WaitForSeconds(1f);
            tiempoDeContador--;
            cronometroTP.text = tiempoDeContador.ToString();
        }
    }
}
