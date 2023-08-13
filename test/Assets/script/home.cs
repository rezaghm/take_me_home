using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour
{
    private radio enter_in_radio;
    // Start is called before the first frame update
    void Start()
    {
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseEnter()
    {
        enter_in_radio.in_home = true;
        enter_in_radio.enter_tile = true;
        enter_in_radio.intile = true;
        enter_in_radio.stop_drawing = false;
    }
    public void OnMouseExit()
    {
        enter_in_radio.in_home=false;
        enter_in_radio.enter_tile=false;
    }
    public void OnMouseDrag()
    {
        enter_in_radio.stop_drawing = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            enter_in_radio.end = true;
        }
    }
}
