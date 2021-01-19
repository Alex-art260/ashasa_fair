using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class  GameController: MonoBehaviour
{

    [SerializeField] private GameObject _textInBeginLevel;


    public static bool checkLevelOne = false;
    public static bool checkLevelTwo = false;
    public static bool checkLevelThree = false;

   
    private void Start()
    {
            Destroy(_textInBeginLevel, 1f);
    }
    
    public void Play()
    {
        checkLevelOne = true;
        SceneManager.LoadScene("Level1");
    }

    public void ContinueAfterLevelOne()
    {
        checkLevelTwo = true;
        checkLevelOne = false;
        SceneManager.LoadScene("Level2");
        ScoreText.scoreValue = 0;
    }

    public void ContinueAfterLevelTwo()
    {
        checkLevelOne = false;
        checkLevelTwo = false;
        checkLevelThree = true;
        SceneManager.LoadScene("Level3");
        ScoreText.scoreValue = 0;
    }
}
