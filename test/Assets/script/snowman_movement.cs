using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowman_movement : MonoBehaviour
{
    public drawing_whith_mous drawcontroll;
    public float speed = 10f;
    Vector3[] positions;
    bool startmovment = false;
    int move_index = 0;
    private radio enter_in_radio;
    private bool intile;
    
   

    private void Start()
    {
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
        
    }

    private void OnMouseDown()
    {
        drawcontroll.StartLine(transform.position);
    }
    private void OnMouseDrag() 
    {
        if (enter_in_radio.enter_tile == true && enter_in_radio.stop_drawing == false )
        {
            drawcontroll.UpdateLine();
            
            enter_in_radio.drawing = true;
        }
        

    }
    private void OnMouseUp()
    {

        if (enter_in_radio.balot_in_scene == true)
        {
            if (enter_in_radio.in_home == true && enter_in_radio.balot_collected == true)
            {
                movment();
            }

            enter_in_radio.balot_collected = false;
        }
        else
        {
            if (enter_in_radio.in_home == true)
            {
                movment();
            }
        }
        
        
        
        
        enter_in_radio.drawing = false;
        enter_in_radio.stop_drawing = false;
        enter_in_radio.stop_drawing_count = true;



    }
    private void OnMouseEnter()
    {
        enter_in_radio.stop_drawing = false;
        enter_in_radio.enter_tile = true;
        enter_in_radio.intile = true;
        enter_in_radio.insowman = true;
        enter_in_radio.draw = true;
    }
    private void OnMouseExit()
    {
        enter_in_radio.enter_tile = false;
        
        enter_in_radio.insowman = false;
    }
    public void movment()
    {
        positions = new Vector3[drawcontroll.line.positionCount];
        drawcontroll.line.GetPositions(positions);
        startmovment = true;
        enter_in_radio.instone = true;
        move_index = 0;
    }
   
    private void Update()
    {
        if (startmovment == true)
        {
            Vector2 currentpos = positions[move_index];
            transform.position = Vector3.MoveTowards(new Vector3(transform.position.x , transform.position.y ,-1), currentpos,speed*Time.deltaTime);

            //rotate
           // Vector2 dir = currentpos - (Vector2)transform.position;
            //float angle = Mathf.Atan2(dir.normalized.y, dir.normalized.x);
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 0f), speed);

            float distance =Vector2.Distance(currentpos,transform.position);
            if (distance <= 0.5f) { 

                move_index++;
            
            }
            if (move_index >= positions.Length - 1)
            {
                startmovment=false;
            }
        }
    }
}
