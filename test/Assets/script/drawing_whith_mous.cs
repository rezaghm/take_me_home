using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class drawing_whith_mous : MonoBehaviour
{
    public LineRenderer line;
    private Vector3 previousposition;

    [SerializeField]
    private float mindistance = 0.1f;
    [SerializeField,Range(0.1f,2f)]
    private float width;
    private radio enter_in_radio;



    // Start is called before the first frame update
    void Start()
    {
        enter_in_radio = GameObject.FindGameObjectWithTag("radio").GetComponent<radio>();
        line = GetComponent<LineRenderer>();
        line.positionCount = 1;
        previousposition = transform.position;
        line.startWidth = line.endWidth = width;
    }

    public void StartLine(Vector2 position)
    {
        line.positionCount = 1;
        line.SetPosition(0, position);
    }
    public void UpdateLine()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 currentposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentposition.z = 0f;

            if(Vector3.Distance(currentposition, previousposition) > mindistance)
            {
                if (previousposition == transform.position)
                {
                    line.SetPosition(0, currentposition);

                }
                else
                {
                    line.positionCount++;
                    line.SetPosition(line.positionCount - 1, currentposition);
                }
               
                previousposition = currentposition;


            }



        }
        
        
    }
    private void Update()
    {
        if (enter_in_radio.stop_drawing == true)
        {
            stop_drawing();
        }
    }
    public void OnMouseDown()
    {
        
    }
    private void OnMouseUp()
    {



        stop_drawing();
        
        enter_in_radio.stop_drawing = false;


    }
    public void stop_drawing()
    {
        Vector3[] points = new Vector3[0];
        //Something something ...
        line.positionCount = points.Length;
        line.SetPositions(points);
    }
  
   
}
