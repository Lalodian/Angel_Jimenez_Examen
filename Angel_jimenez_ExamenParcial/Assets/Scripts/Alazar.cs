using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Alazar : MonoBehaviour
{
    public GameObject enemigo;
    public float tiempoDeRespwn;
    private float maximoX=8;
    private float minimoX=-8;
    private float maximoZ=7;
    private float minimoZ=-7;

    private float tiempo;
    void Start()
    {
        tiempo = tiempoDeRespwn;
    }
    void Update()
    {
        Respawn();
    }
    public void Respawn()
    {
        tiempo+=Time.deltaTime;
        if(tiempo>=tiempoDeRespwn)
        {
            tiempo=0f;
            float aleatorio1 = Random.Range(maximoX, minimoX);
            float aleatorio2 = Random.Range(maximoZ, minimoZ);
            GameObject prefapObjeto = Instantiate(enemigo, new Vector3(aleatorio1, 8, aleatorio2), Quaternion.identity);
        }
           
    }
}
