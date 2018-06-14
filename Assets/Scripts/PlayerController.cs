using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Transform player;

    public int speed = 2500;

    private void OnMouseDrag(){
        Vector2 mousePos = Input.mousePosition;
        
        //mousePos.x = mousePos.x < 44f ? 44f : mousePos.x;
        //пример тринарного оператора 
        if (mousePos.x < 44f){
            mousePos.x = 44f;
        }
        
        //mousePos.x = mousePos.x > 590f ? 590f : mousePos.x;   
        //пример тринарного оператора 
        if (mousePos.x > 590f){
          mousePos.x = 590f;
        }
        player.position = Vector2.MoveTowards(player.position,new Vector2(mousePos.x, player.position.y),speed * Time.deltaTime);

    }

}
