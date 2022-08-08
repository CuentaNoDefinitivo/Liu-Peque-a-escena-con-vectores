using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//creo que enum es algo para crear un tipo de variable, y que ese tipo de variable solo puede valer lo que le ponga dentro de las llaves
public enum Movements 
{
    MovementA, 
    MovementB
}
public class EnemyCMovement : MonoBehaviour
{
    [SerializeField] Movements enemyMovement = Movements.MovementA;
    EnemyAMovement a;
    EnemyBMovement b;


    void Start()
    {
        a = GetComponent<EnemyAMovement>();
        b = GetComponent<EnemyBMovement>();


        switch (enemyMovement)
        {
            case Movements.MovementA:
                a.enabled = true;
                b.enabled = false;
                break;
            case Movements.MovementB:
                a.enabled = false;
                b.enabled = true;
                break;
        }
    }
}
