using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    [SerializeField] GameObject startGame;
    [SerializeField] GameObject dialogueAshas;
    [SerializeField] GameObject dialogueAshas3;
    [SerializeField] GameObject dialogueAshas4;
    [SerializeField] GameObject nameGame;
    [SerializeField] GameObject writeName;
    //public bool _activeLevel = false;


    public void StartGame()
    {
        nameGame.SetActive(false);
        startGame.SetActive(false);
        dialogueAshas.SetActive(true);
    }

    public void Continue()
    {
        dialogueAshas.SetActive(false);
        writeName.SetActive(true);
    }

    public void ContinueAfterWriteName()
    {
        writeName.SetActive(false);
        dialogueAshas.SetActive(true);
    }

    public void YesButton()
    {
        dialogueAshas3.SetActive(false);
        dialogueAshas4.SetActive(true);
    }

    /*public void Play()
    {
        _activeLevel = true;
        SceneManager.LoadScene("Level1");
    }*/
}
