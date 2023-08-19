using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawing_box : MonoBehaviour
{
    private radio enter_in_radio;
    public BoxCollider2D boxCollider;
    private bool stop_drawing_count = true;
    // Start is called before the first frame update
    void Start()
    {
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enter_in_radio.drawing == true)
        {
            boxCollider.enabled = true;
        }
        else
        {
            boxCollider.enabled = false;
        }
    }
    public void OnMouseEnter()
    {
        if(stop_drawing_count == true)
        {
            enter_in_radio.stop_drawing = false;
            stop_drawing_count = false;
        }
        
        enter_in_radio.dont_cut = true;

    }
    public void OnMouseExit()
    {
        enter_in_radio.dont_cut=false;
        enter_in_radio.stop_drawing=true;
        
        
    }
}
