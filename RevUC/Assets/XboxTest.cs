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
        leftAnalogStickHorizontal = Input.GetAxis("Left Analog Stick (Horizontal)");
        leftAnalogStickVertical = Input.GetAxis("Left Analog Stick (Vertical)");
        Debug.Log("A button pressed" + aButton);
        Debug.Log("A button pressed" + leftAnalogStickHorizontal);
        Debug.Log("A button pressed" + leftAnalogStickVertical);

    }
}
