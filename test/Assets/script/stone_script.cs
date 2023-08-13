using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone_script : MonoBehaviour
{
    private radio enter_in_radio;
    public Collider2D tile;
    // Start is called before the first frame update
    void Start()
    {
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.gameObject.layer == 7)
        //{
            //collision.isTrigger = false;
        //}
        //tile = collision;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.gameObject.layer == 7) { tile.isTrigger = true; }
        
    }
    

}
