using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMechanics : MonoBehaviour
{

    public static List<int> RodLeft = new List<int>();
    public static List<int> RodMid = new List<int>();
    public static List<int> RodRight = new List<int>();
    public static bool isGrabbing = false;
    public static int onHand;
    public static int TotalRings;
    public static int RodNum = 0;
    public static bool isNearRod = false;
    public static float Timer;
    public static int moves;
    [SerializeField] Text TimeCounter;
    [SerializeField] Text MovesCounter;



    // Start is called before the first frame update
    void Start()
    {
        for(int x = TotalRings; x > 0; x--){
            RodLeft.Add(x);
        }

    }

    // Update is called once per frame
    void Update()
    {
        Timer += 1 * Time.deltaTime;
        TimeCounter.text = "Timer: " + Timer.ToString("00");
        MovesCounter.text = "Moves: " + moves.ToString();
    }
}
