using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod_Left : MonoBehaviour
{
    [SerializeField] AudioSource Source;
    [SerializeField] AudioClip move;
    [SerializeField] AudioClip deny;

    private void OnMouseDown() {
        if(GameMechanics.isGrabbing == false && GameMechanics.RodLeft.Count > 0){
            GameMechanics.onHand = GameMechanics.RodLeft[GameMechanics.RodLeft.Count - 1];
            GameMechanics.isGrabbing = true;
            GameMechanics.RodLeft.Remove(GameMechanics.RodLeft[GameMechanics.RodLeft.Count - 1]);
            GameMechanics.moves += 1;
            Source.PlayOneShot(move);
        }

        else if (GameMechanics.isGrabbing == true){
            if(GameMechanics.RodLeft.Count > 0){
                if(GameMechanics.onHand < GameMechanics.RodLeft[GameMechanics.RodLeft.Count - 1]){
                    GameMechanics.RodLeft.Add(GameMechanics.onHand);
                    GameMechanics.onHand = 0;
                    GameMechanics.isGrabbing = false;
                }
                else{
                    Source.PlayOneShot(deny);
                }
            }
            else{
                GameMechanics.RodLeft.Add(GameMechanics.onHand);
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
        GameMechanics.RodNum = 1;
    }

}
