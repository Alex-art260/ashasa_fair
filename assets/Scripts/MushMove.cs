using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushMove : MonoBehaviour
{
    public float speed;

    void Start()
    {
        transform.position = new Vector2(-10, 3);
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed);
    }
}
