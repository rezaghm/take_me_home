using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public tile_movment movment;
    
    // Start is called before the first frame update
    void Start()
    {
       movment = GameObject.FindGameObjectWithTag("tile").GetComponent<tile_movment>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
            
            
        
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("enred");
    }

}
