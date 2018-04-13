using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlus : MonoBehaviour {

    public int scoreCounter;
    public Text score;

     void Start()
    {
        score.text = "Score: 0"; 
    }

    public void OnClickAction()
    {
        ScoreCounterPlus();
    }

    public void OnClickActionMin()
    {
        ScoreCounterMin();
    }


    void ScoreCounterPlus()
    {
        score.text = "Score: " + ++scoreCounter;
    }

    void ScoreCounterMin()
    {
        score.text = "Score: " + --scoreCounter;
    }

}
