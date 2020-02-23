using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XboxTest : MonoBehaviour
{

    public bool aButton;
    //public bool menuButton;
    public float leftAnalogStickHorizontal;
    public float leftAnalogStickVertical;
    private Rigidbody playerRigidbody;
    private float speed = 10.0f;
    private Vector3 vel;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        aButton = Input.GetButton("A Button");
        //menuButton = Input.GetButton("Menu Button");
        leftAnalogStickHorizontal = Input.GetAxis("Left Analog Stick (Horizontal)") * 5;
        leftAnalogStickVertical = Input.GetAxis("Left Analog Stick (Vertical)") * 5;
        Debug.Log("A button pressed" + aButton);
        Debug.Log("left button pressed" + leftAnalogStickHorizontal);
        Debug.Log("right button pressed" + leftAnalogStickVertical);
       

        vel = playerRigidbody.velocity;
        vel.x = leftAnalogStickHorizontal;
        vel.y = leftAnalogStickVertical;
        playerRigidbody.velocity = vel;
        Debug.Log(vel);
    }
}
