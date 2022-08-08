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
        //creo que esta función devuelve la rotación del vector, la inclinación del vector
        angleToLook = Quaternion.LookRotation(- transform.position + player.position,Vector3.up);
        //¿¿Y qué es lo que devuelve lerp?? qué es lo que hace?
        transform.rotation = Quaternion.Lerp(transform.rotation, angleToLook, 0.003f);
        /*por alguna razón está alrevés -_-, ¿porqué transform.position-player.position mira al revés?,
        me parece que el que tiene que mirar al revés es player.position-transform.position, pero esta es la que funciona*/

        //y rota también en el eje x z, o sea que si subo a la rampa el enemigo se tumba, ¿Cómo se puede hacer que gire solo en el eje y?
    }
}
