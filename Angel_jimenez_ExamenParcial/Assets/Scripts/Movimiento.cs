using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.U2D;

public class Movimiento : MonoBehaviour
{
    public float velocidadDelPlayer;
    //Variables de rotacion
    public float rotacionDelPlayer;
    private float direccionDeRotacion;
    private Rigidbody playerRB;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
        MovimientoPlayer();
    }
    public void MovimientoPlayer()
    {
       float movimientoHorizontal = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.A))
        {
            direccionDeRotacion = -1f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direccionDeRotacion = 1f;
        }

        Vector3 fuerzaDeMovimiento = transform.right * velocidadDelPlayer * movimientoHorizontal;
        playerRB.velocity = fuerzaDeMovimiento;
        Vector3 fuerzaDeRotacion= transform.up * direccionDeRotacion * rotacionDelPlayer;
        playerRB.angularVelocity = fuerzaDeMovimiento;
        if(Input.GetKeyUp(KeyCode.A)|| Input.GetKeyUp(KeyCode.D))
        {
            direccionDeRotacion = 0f;
            playerRB.angularVelocity = Vector3.zero;
        }
    }
}
