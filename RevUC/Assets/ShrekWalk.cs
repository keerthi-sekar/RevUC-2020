using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrekWalk : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject wayPoint;
    private Vector3 wayPointPos;

    private float speed = 6.0f;

    void Start()
    {
        wayPoint = GameObject.Find("wayPoint");
    }

    // Update is called once per frame
    void Update()
    {
        wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
    }
}
