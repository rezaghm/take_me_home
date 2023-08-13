using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_fix : MonoBehaviour
{
    public Rigidbody2D _rb;
    public Transform targetObject;

    void Start()
    {
        //targetObject = GameObject.FindGameObjectWithTag("target").transform;
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Rotate
        var direction = targetObject.transform.position - transform.position;
        var _rotation = Quaternion.LookRotation(direction, transform.TransformDirection(0, 0, 1));
        transform.rotation = new Quaternion(0, 0, _rotation.z, _rotation.w);
    }
}
