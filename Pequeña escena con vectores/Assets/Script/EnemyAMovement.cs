using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAMovement : MonoBehaviour
{
    [SerializeField] Transform player;
    Quaternion angleToLook;

    void Start()
    {
        
    }

    void Update()
    {
        //creo que esta funci�n devuelve la rotaci�n del vector, la inclinaci�n del vector
        angleToLook = Quaternion.LookRotation(- transform.position + player.position,Vector3.up);
        //��Y qu� es lo que devuelve lerp?? qu� es lo que hace?
        transform.rotation = Quaternion.Lerp(transform.rotation, angleToLook, 0.003f);
        /*por alguna raz�n est� alrev�s -_-, �porqu� transform.position-player.position mira al rev�s?,
        me parece que el que tiene que mirar al rev�s es player.position-transform.position, pero esta es la que funciona*/

        //y rota tambi�n en el eje x z, o sea que si subo a la rampa el enemigo se tumba, �C�mo se puede hacer que gire solo en el eje y?
    }
}
