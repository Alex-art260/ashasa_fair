using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] GameObject endLevelText;
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject ashas;

    public static int scoreValue;
    public Text score;
    public int finishScore;

    private void Start()
    {
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = " " + scoreValue;

        if(scoreValue == 5)
        {
            endLevelText.SetActive(true);
            spawner.SetActive(false);
            ashas.SetActive(false);
        }
    }
}
