using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaThrow : MonoBehaviour
{
    public float speed;

    public float cooldown = 0f;


    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "FirePoint")
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
            GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
        }
    }




}
