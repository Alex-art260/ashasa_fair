using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkBasket : MonoBehaviour
{
    public Material matBlink;
    public Material matDefault;
    public SpriteRenderer spriteRend;

    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
    }

}



