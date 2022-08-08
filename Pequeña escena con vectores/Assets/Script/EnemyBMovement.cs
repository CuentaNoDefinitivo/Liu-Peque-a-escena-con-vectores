using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBMovement : MonoBehaviour
{
    [SerializeField] Transform playerToFollow;
    [SerializeField] float speed = 5;
    Vector3 trayectory;

    void Update()
    {
        trayectory = transform.position - playerToFollow.position;
        if (trayectory.magnitude >= 2)
        {
            // le multipliqu� por menos uno porque por alg�n motivo va alrev�s, o sea que huye en vez de venir a perseguir
            transform.Translate(trayectory.normalized * -1 * speed * Time.deltaTime);
        }
    }
}
