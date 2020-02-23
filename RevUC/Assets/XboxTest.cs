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
    private float speed = 2.25f;
    private Vector3 vel;
    public float distance = 1;
    GameObject playerPosition;

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
        leftAnalogStickHorizontal = Input.GetAxis("Left Analog Stick (Horizontal)") * speed;
        leftAnalogStickVertical = Input.GetAxis("Left Analog Stick (Vertical)") * speed;
       
        var cam = Camera.main;
        var forward = cam.transform.forward;
        var right = cam.transform.right;
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();
        var desiredMoveDirection = -forward * leftAnalogStickVertical + right * leftAnalogStickHorizontal;
        gameObject.transform.Translate(desiredMoveDirection * speed * Time.deltaTime);
    }
}
