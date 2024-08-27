using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    [SerializeField] Text TimeScore;
    [SerializeField] Text MoveScore;

    // Start is called before the first frame update and just post the score and resets it when button is pressed
    void Start()
    {
        TimeScore.text = "Time: " + GameMechanics.Timer.ToString("00");
        MoveScore.text = "Moves: " + GameMechanics.moves.ToString();
    }
}
