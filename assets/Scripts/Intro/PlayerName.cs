using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName: MonoBehaviour
{
    public InputField inputF;
    public string Name;

    void Update()
    {
        Name = inputF.textComponent.text;
    }
   
}