using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private float x, y, z;
    public float speed = 1;
    public float amplitude;
    public bool Sin = false;

    public GameObject sinUI,cosUI;
    private Text cosText, sinText;
    private Rigidbody _rigidbody;
    private Transform _transform;

    private void Awake()
    {
        sinText = sinUI.GetComponent<Text>();
        cosText = cosUI.GetComponent<Text>();
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Sin)
        {
            y = Mathf.Sin(Time.time*speed)*amplitude ;
            _transform.position = new Vector3(_transform.position.x+Time.deltaTime*3,y,z);
            sinText.text = $"Sin = {Mathf.Sin(Time.time*speed)*3:#0.00}";
        }
        else
        {
            y = Mathf.Cos(Time.time*speed)*amplitude ;
            _transform.position = new Vector3(_transform.position.x+Time.deltaTime*3,y,z);
            cosText.text = $"Cos = {Mathf.Cos(Time.time*speed)*3:#0.00}";

        }

    }
}
