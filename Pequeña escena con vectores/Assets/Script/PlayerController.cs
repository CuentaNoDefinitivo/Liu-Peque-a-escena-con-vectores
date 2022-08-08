using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] CharacterController player;
    [SerializeField] public float speed = 20;
    [SerializeField] public float rotationSpeed = 10f;

    Vector3 input = Vector3.zero;
    float inputRotation = 0;

    void Start()
    {
        /*hasta ahora siempre para acceder a las clases p�blicas se escribe solo el nombre de la clase, como por ejemplo la clase Input o Vector3,
        �y porqu� para acceder a la clase Character controller necesita el metodo GetComponent?*/
        //�y porqu� este metodo tiene <> ? �para dar valores al metodo no se escribe dentro del par�ntesis? hasta ahora ning�n metodo ten�a <>
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        inputRotation += Input.GetAxis("Mouse X");//el Axis Mouse X es que, cada punto de la pantalla vale valor o cada direcci�n y fuerza del raton(el vector) vale un valor?
        input = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            input.z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            input.z = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            input.x = -1;
        }
        //�qu� diferencia hay entre SimpleMove() y Move()? �y porqu� cuando uso el metodo Move() no tiene gravedad y cuando uso el metodo SimpleMove() ti lo tiene?
        player.SimpleMove(input.normalized* speed);
        transform.rotation = Quaternion.Euler(0, inputRotation * rotationSpeed, 0);
        //transform.Rotate(0, inputRotation * rotationSpeed, 0);
        //transform.LookAt(Input.mousePosition,Vector3.up); �porqu� con este metodo solo rota en el eje z?
    }
}
