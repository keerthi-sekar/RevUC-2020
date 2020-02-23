using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ShrekAttack : MonoBehaviour
{
    public Transform shrekPosition; //start
    public GameObject playerRig; //end
    private float startTime = 0.0f;
    private bool test = false;

    private void Start()
    {
        startTime = Time.time;
    }

    public void AttackPlayer()
    {
        shrekPosition.position = this.gameObject.transform.position;
        Debug.Log(Time.time);
        Debug.Log(startTime);
        float distCovered = (Time.time - startTime) * 2.0f;
        float journeyLength = Vector3.Distance(shrekPosition.position, playerRig.transform.position);
        float fractionOfJourney = distCovered / journeyLength;

        gameObject.transform.position = Vector3.Lerp(shrekPosition.position, playerRig.transform.position, fractionOfJourney);
    }
    
}
