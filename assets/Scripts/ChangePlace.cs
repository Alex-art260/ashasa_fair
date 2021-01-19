using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlace : MonoBehaviour
{
    public GameObject basket1;
    public GameObject basket2;

    Vector2 position1 = new Vector2(-2.5f, -1.4f);
    Vector2 position2 = new Vector2(2.5f, -1.4f);



    void Start()
    {
     //   basket1.transform.position = new Vector2(-2.5f, -1.5f);
     //   basket2.transform.position = new Vector2(2.5, -1.5f);
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        Debug.Log("1111");
        if(collision.gameObject.name == "Bascet1")
        {
            Debug.Log("2222");
            var positionCash = basket1.transform.position;
            basket1.transform.position = basket2.transform.position;// = position1;
            basket2.transform.position = positionCash;
        }
      


    }
}
