using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stars_for_menu : MonoBehaviour
{
    public Text stars;
    private radio enter_in_radio;
    private bool sicle = true;
    // Start is called before the first frame update
    void Start()
    {
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sicle == true)
        {
            stars.text = enter_in_radio.star_count.ToString();
           sicle = false;
        }
        
    }
}
