using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod_Mid : MonoBehaviour
{
    [SerializeField] AudioSource Source;
    [SerializeField] AudioClip move;
    [SerializeField] AudioClip deny;

    //checks out if the rod is being pressed then follows the mouse
    private void OnMouseDown() {
        if(GameMechanics.isGrabbing == false && GameMechanics.RodMid.Count > 0){
            GameMechanics.onHand = GameMechanics.RodMid[GameMechanics.RodMid.Count - 1];
            GameMechanics.isGrabbing = true;
            GameMechanics.RodMid.Remove(GameMechanics.RodMid[GameMechanics.RodMid.Count - 1]);
            GameMechanics.moves += 1;
            Source.PlayOneShot(move);
        }
    //this checks if the rod is empty or has something on it. It's a fix with having negative due to how I handled the grabbing the last item in a list
        else if (GameMechanics.isGrabbing == true){
            if(GameMechanics.RodMid.Count > 0){
                if(GameMechanics.onHand < GameMechanics.RodMid[GameMechanics.RodMid.Count - 1]){
                    GameMechanics.RodMid.Add(GameMechanics.onHand);
                    GameMechanics.onHand = 0;
                    GameMechanics.isGrabbing = false;
                }
                else{
                    Source.PlayOneShot(deny);
                }
            }
            else{
                GameMechanics.RodMid.Add(GameMechanics.onHand);
                GameMechanics.onHand = 0;
                GameMechanics.isGrabbing = false;  
            }
        }
    }


//just a simple algorithm that locks the object on the top of the rod to avoid any collisions and break ins withing the pyramids
    private void OnMouseExit() {
        GameMechanics.isNearRod = false;
        GameMechanics.RodNum = 0;
    }

    private void OnMouseEnter() {
        GameMechanics.isNearRod = true;
        GameMechanics.RodNum = 2;
    }

}
