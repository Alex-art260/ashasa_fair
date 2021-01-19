using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseInputfield : MonoBehaviour
{
    public GameObject Ashas;
    public GameObject writeNamePanel;

    public GameObject playerName;
    private string _namePlayer;
    [TextArea(3, 10)]
    public string textDialog;
    public Text text1;
   
    public void Continue()
    {
        Ashas.SetActive(true);
        writeNamePanel.SetActive(false);
        _namePlayer = playerName.GetComponent<PlayerName>().Name;
        text1.text = "Рад с тобой познакомиться, "  + _namePlayer + "." + textDialog;
    }
}
