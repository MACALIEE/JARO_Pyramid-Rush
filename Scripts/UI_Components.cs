using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Components : MonoBehaviour
{
    int level = 3;
    [SerializeField] Text LevelCounter;
//resets everything and goes back to menu might used to on the end of the game
    public void surrender(){
        SceneManager.LoadScene("Menu");
    }


//selects level based on the int set from the buttons default is 3 
  
    public void select_level(){

    // Resetting rods and game variables to retry level
    GameMechanics.RodLeft.Clear();
    GameMechanics.RodMid.Clear();
    GameMechanics.RodRight.Clear();
    GameMechanics.isGrabbing = false;
    GameMechanics.onHand = 0;

        switch(level){
            case 1:
                SceneManager.LoadScene("Level1");
                GameMechanics.TotalRings = 1;
                GameMechanics.Timer = 0;
                GameMechanics.moves = 0;
                break;
            case 2:
                SceneManager.LoadScene("Level2");
                GameMechanics.TotalRings = 2;
                GameMechanics.Timer = 0;
                GameMechanics.moves = 0;
                break;
            case 3:
                SceneManager.LoadScene("Level3");
                GameMechanics.TotalRings = 3;
                GameMechanics.Timer = 0;
                GameMechanics.moves = 0;
                break;
            case 4:
                SceneManager.LoadScene("Level4");
                GameMechanics.TotalRings = 4;
                GameMechanics.Timer = 0;
                GameMechanics.moves = 0;
                break;
            case 5:
                SceneManager.LoadScene("Level5");
                GameMechanics.TotalRings = 5;
                GameMechanics.Timer = 0;
                GameMechanics.moves = 0;
                break;
            case 6:
                SceneManager.LoadScene("Level6");
                GameMechanics.TotalRings = 6;
                GameMechanics.Timer = 0;
                GameMechanics.moves = 0;
                break;
            case 7:
                SceneManager.LoadScene("Level7");
                GameMechanics.TotalRings = 7;
                GameMechanics.Timer = 0;
                GameMechanics.moves = 0;
                break;
            case 8:
                SceneManager.LoadScene("Level8");
                GameMechanics.TotalRings = 8;
                GameMechanics.Timer = 0;
                GameMechanics.moves = 0;
                break;
        }
    }


//adding a level up
    public void add_level(){
        if(level < 8){
            level += 1;
        }
        LevelCounter.text = "level " + level.ToString() + " Start!";
    }
//adding level down
    public void sub_level(){
        if(level > 1){
            level -= 1;
        }
        LevelCounter.text = "level " + level.ToString() + " Start!";
    }
}
