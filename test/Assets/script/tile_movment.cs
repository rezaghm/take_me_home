using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class tile_movment : MonoBehaviour
{
    private float startposex;
    private float startposey;
    public int spead;
    
    public bool Unparent = true;
    private radio enter_in_radio;
    private bool cuted1 = false;
    [SerializeField]
    public bool entered;
    public bool snowman1;
    public bool isbeingheld1;
    public float horizental_tile;
    public float vertical_tile;
    Vector3 horizental_snap;
    Vector3 vertical_snap;
    public bool issnaping_horizental ;
    public bool issnaping_vertical;
    public BoxCollider2D boxcol;
    public CapsuleCollider2D capsulecol;
    public bool instone;
    public bool add_one;
    private logic_script enter_in_logic_script;
    public bool add_score;


    public float destance_from_mouse = 2;





    private void Start()
    {
        enter_in_logic_script = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
         instone = enter_in_radio.instone;
        
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (cuted1 == true)
        {

            //Debug.Log("move");
            if (isbeingheld1 == true)
            {
                Vector3 mousepos;
                mousepos = Input.mousePosition;
                mousepos = Camera.main.ScreenToWorldPoint(mousepos);

                this.gameObject.transform.localPosition = new Vector3(mousepos.x, mousepos.y, 0);
                if (Unparent == true)
                {
                    gameObject.transform.SetParent(null);
                }





            }
        }

        if (enter_in_radio.draw == false && enter_in_radio.drawing == true)
        {

            if (3 > destance_from_mouse)
            {
                if (enter_in_radio.in_home == false)
                {
                    enter_in_radio.stop_drawing = true;
                    
                }
            }
        }

    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousepos;
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToViewportPoint(mousepos);
            enter_in_radio.isbeingHeld = true;
            isbeingheld1 = true;
            
            startposex = mousepos.x - this.transform.localScale.x;
            startposey = mousepos.y - this.transform.localScale.y;
            
            if (add_score == true)
            {
                
                enter_in_logic_script.addscore();
                
            }
            

        }
        
        
    }
    private void OnMouseUp() {
        enter_in_radio.isbeingHeld = false;
        isbeingheld1 = false;
        add_score = false;
        if (issnaping_vertical== true)
        {
            transform.position = vertical_snap;
        }
        else if (issnaping_horizental== true)
        {
            transform.position = horizental_snap;
        }
        boxcol.isTrigger = true;
        capsulecol.isTrigger = true;
        add_one = false;
    
    
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {

            add_score = true;
            cuted1 = true;
        }
       
     


    }
   // public void OnTriggerStay2D(Collider2D collision)
    //{
        //if (collision.gameObject.layer == 7)
       // {
            //if (collision is CapsuleCollider2D)
           // {
               // issnaping_horizental = true;
               // horizental_snap = new Vector3(transform.position.x, collision.gameObject.transform.position.y, 0);
          //  }
           // else if (collision is BoxCollider2D)
            //{
               // issnaping_vertical = true;
               // vertical_snap = new Vector3(collision.gameObject.transform.position.x, transform.position.y, 0);
           // }
       // }

    //}

    public void OnTriggerExit2D(Collider2D collision)
    {
        issnaping_horizental = false;
        issnaping_vertical = false;
    }

    public void OnMouseEnter()
    {
        enter_in_radio.draw = true;
        enter_in_radio.enter_tile = true;
        enter_in_radio.intile = true;
        enter_in_radio.stop_drawing = false;

    }
    public void OnMouseExit()
    {
        enter_in_radio.draw = false;
        enter_in_radio.enter_tile = false;
        enter_in_radio.intile = false;
        

        
    }

}
