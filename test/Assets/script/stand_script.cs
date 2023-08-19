using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stand_script : MonoBehaviour
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
        enter_in_radio.enter_tile = true;
        enter_in_radio.draw = true;
        enter_in_radio.intile = true;
        

    }
    public void OnMouseExit()
    {
        enter_in_radio.draw = false;
        enter_in_radio.enter_tile = false;

    }
}
