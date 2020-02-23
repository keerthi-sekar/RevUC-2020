using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private int totalTime = 30;
    public GameObject uiMenu;
    public TextMeshPro timer;

    private void Update()
    {
        if(Input.GetButton("A Button"))
        {
            uiMenu.SetActive(false);
            StartCoroutine(TimerCountdown());
        }
    }

    private IEnumerator TimerCountdown()
    {
        while(totalTime >= 1)
        {
            yield return new WaitForSeconds(1);
            timer.text = "00:" + totalTime.ToString();
            totalTime--;
        }
        if(totalTime == 0)
        {
            Debug.Log("Game Over");
        }
    }
}
