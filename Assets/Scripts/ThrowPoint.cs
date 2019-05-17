using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPoint : MonoBehaviour
{

    public GameObject PizzaThrow;
    public Transform throwPoint;

    private void FixedUpdate()
    {
        bool shoot = Input.GetButtonDown("Fire1");

        if (shoot)
        {
            Instantiate(PizzaThrow, throwPoint.position, throwPoint.rotation);
        }
    }
}
