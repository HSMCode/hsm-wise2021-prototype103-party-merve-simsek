using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void Start()
    {
        theScore = 0;
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
    }
   
    void Update ()
    {
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
    }
}
