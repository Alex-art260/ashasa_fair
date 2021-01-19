using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private float _speed;
    public float horizontalSpeed;

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _speed = horizontalSpeed;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            _speed = horizontalSpeed;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        transform.Translate(_speed, 0, 0);
        _speed = 0;
    }
}
