using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balot : MonoBehaviour
{
    private radio enter_in_radio;
    public SpriteRenderer balot_image;
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
        enter_in_radio.balot_collected = true;
        enter_in_radio.enter_tile = true;
        enter_in_radio.draw = true;
        enter_in_radio.intile = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            balot_image.enabled = false;
        }
    }
}
