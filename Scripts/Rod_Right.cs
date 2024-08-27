using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rod_Right : MonoBehaviour
{
    [SerializeField] AudioSource Source;
    [SerializeField] AudioClip move;
    [SerializeField] AudioClip deny;
    // Update is called once per frame
    void Update()
    {
        if(GameMechanics.RodRight.Count >= GameMechanics.TotalRings){
            SceneManager.LoadScene("End");
        }
    }

    private void OnMouseDown() {
        if(GameMechanics.isGrabbing == false && GameMechanics.RodRight.Count > 0){
            GameMechanics.onHand = GameMechanics.RodRight[GameMechanics.RodRight.Count - 1];
            GameMechanics.isGrabbing = true;
            GameMechanics.RodRight.Remove(GameMechanics.RodRight[GameMechanics.RodRight.Count - 1]);
            GameMechanics.moves += 1;
            Source.PlayOneShot(move);
        }

        else if (GameMechanics.isGrabbing == true){
            if(GameMechanics.RodRight.Count > 0){
                if(GameMechanics.onHand < GameMechanics.RodRight[GameMechanics.RodRight.Count - 1]){
                    GameMechanics.RodRight.Add(GameMechanics.onHand);
                    GameMechanics.onHand = 0;
                    GameMechanics.isGrabbing = false;
                }
                else{
                    Source.PlayOneShot(deny);
                }
            }
            else{
                GameMechanics.RodRight.Add(GameMechanics.onHand);
                GameMechanics.onHand = 0;
                GameMechanics.isGrabbing = false;  
            }
        }
    }

    private void OnMouseExit() {
        GameMechanics.isNearRod = false;
        GameMechanics.RodNum = 0;
    }

    private void OnMouseEnter() {
        GameMechanics.isNearRod = true;
        GameMechanics.RodNum = 3;
    }
}
