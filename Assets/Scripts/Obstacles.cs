using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject player;
    public int damage = 5;
    public float distance;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        distance = (player.transform.position - transform.position).magnitude;

        if (distance <= 8)
        {
            if (player.transform.position.x > transform.position.x)
            {
                transform.position += transform.right * speed * Time.deltaTime;
            }

            if (player.transform.position.x < transform.position.x)
            {
                transform.position += -transform.right * speed * Time.deltaTime;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().TakeDamage(5);
            Destroy(gameObject);
        }
    }
}

