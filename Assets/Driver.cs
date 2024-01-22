using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float SteerSpeed = 250;
    [SerializeField] float MoveSpeed = 20;
    void speak()
    {
        Debug.Log("Mouninja");
    }

    // Start is called before the first frame update
    void Start()
    {
        
        speak();
    }

    // Update is called once per frame
    void Update()
    {
        float SteerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;
        float Speed = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-SteerAmount);
        transform.Translate(0,Speed,0);
    }
}

