using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    public float speed1;
    public float timer = 0;

    public int health = 25;

    public bool Right;

    public GameObject pizzaUI;

    public Animator anim;

    //als je dood gaat ga je naar het startscherm
    public void TakeDamage(int damage)
    {

        health -= damage;

        if (health <= 0)
        {
            //timer voordat je naar het startscherm gaat met een "you died" scherm?
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("GameOver");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pizzaUI.GetComponent<Animator>().SetInteger("Health", health);

        //basic movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed1 * Time.deltaTime;
            anim.SetInteger("Direction", -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed1 * Time.deltaTime;
            anim.SetInteger("Direction", 1);
        }

        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            anim.SetInteger("Direction", 0);
        }

        timer += Time.deltaTime;

        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.CompareTag("Coins"))
      {
        Destroy(other.gameObject);
      }
    }

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        if (move > 0 && Right) Flip();
        if (move < 0 && !Right) Flip();
    }

    void Flip()
    {
        Right = !Right;
        transform.Rotate(Vector3.up * 180);
    }

}
