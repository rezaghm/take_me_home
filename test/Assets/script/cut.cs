using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cut : MonoBehaviour
{
    
    public int spead;
    private radio enter_in_radio;
    public SpriteRenderer dot;
    public TrailRenderer dot_trail;
    public bool cuting;
    
    


    private void Start()
    {
        
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) && enter_in_radio.isbeingHeld == false && enter_in_radio.intile == false && enter_in_radio.insowman == false && enter_in_radio.drawing == false && enter_in_radio.dont_cut == false)


        {
            Vector3 mousepos2;
            mousepos2 = Input.mousePosition;
            mousepos2 = Camera.main.ScreenToWorldPoint(mousepos2);

            this.gameObject.transform.localPosition = new Vector3(mousepos2.x, mousepos2.y, 0);
            dot.enabled = true; dot_trail.enabled = true;

            



        }
        else
        {
            dot.enabled = false; dot_trail.enabled = false;
        }
      
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cuting = true;
        
        
            
        
    }
    
    
}
