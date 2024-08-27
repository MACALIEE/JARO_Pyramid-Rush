using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public int count;
    private bool isNearRod = false;
    private int RodNum = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameMechanics.onHand == count && GameMechanics.isNearRod == true){
            Vector2 cursorpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorpos.x,cursorpos.y);
        }

        switch(GameMechanics.RodNum){
            case 1:
                if(GameMechanics.onHand == count){
                    transform.position = new Vector2(-5,2);
                }
                break;
            case 2:
                if(GameMechanics.onHand == count){
                    transform.position = new Vector2(0,2);
                }
                break;
            case 3:
                if(GameMechanics.onHand == count){
                    transform.position = new Vector2(5,2);
                }
                break;
            }
    }
}
    
