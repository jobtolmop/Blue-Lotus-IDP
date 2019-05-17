using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.CompareTag("House"))
      {
        ScoreManager.instance.ChangeScore(coinValue);
        Destroy(gameObject);
      }
    }
}
