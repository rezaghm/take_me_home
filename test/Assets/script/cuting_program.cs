using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuting_program : MonoBehaviour
{
    public GameObject cut;
    private radio enter_in_radio;
    Vector3 mousepos;
    Vector3 offset;
    

    // Start is called before the first frame update
    void Start()
    {
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = Input.mousePosition;
        offset = new Vector3(0, 0, 10);
        mousepos = Camera.main.ScreenToWorldPoint(mousepos);
         
        if (Input.GetMouseButton(0))
        {
            Instantiate(cut,mousepos+offset,Quaternion.identity);
        }
    }
}
