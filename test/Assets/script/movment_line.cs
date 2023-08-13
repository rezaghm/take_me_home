using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment_line : MonoBehaviour
{
    private float startposex;
    private float startposey;
    public int spead;
    private bool isbeingcut = false;
    private float moveHorizontal;
    private float moveVertical;
    public Rigidbody2D rb;
    public float moase_limit;



    void Start()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");


        float moveVertical = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {

        if (isbeingcut == true)
        {
            Vector3 mousepos;
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);
            float mousepos_horizontal = mousepos.x * moveHorizontal;
            float mousepos_vertical = mousepos.y * moveVertical;

            this.gameObject.transform.localPosition = new Vector3(mousepos_horizontal, mousepos_vertical, 0);
            
            




        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousepos;
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToViewportPoint(mousepos);
            isbeingcut = true;
            startposex = (mousepos.x - this.transform.localScale.x);
            startposey = (mousepos.y - this.transform.localScale.y);

        }
    }
    private void OnMouseUp()
    {
        isbeingcut = false;


    }
    private void FixedUpdate()
    {

        Vector3 mousepose;
        mousepose = Input.mousePosition;
        mousepose = Camera.main.ScreenToViewportPoint(mousepose);
        float mouseposeX = mousepose.x - this.transform.localScale.x;
        float mouseposeY = mousepose.y - this.transform.localScale.y;


        //We are not currently moving on the x axis

        if (mouseposeX >= moase_limit)
        {
            if (rb.velocity.x != 0)
            {
                moveVertical = 0;
            }
        }
       
        //We are not currently moving on the y axis
        else if (mouseposeY >= moase_limit)
        {
            if (rb.velocity.y != 0)
            {
                moveHorizontal = 0;
            }
        }
        
        //Vector3 Movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //rb.AddForce(Movement);
    }

}
