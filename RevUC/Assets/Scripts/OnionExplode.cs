﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnionExplode : MonoBehaviour
{
    void OnTriggerEnter(Collider hit)
    {
        AudioManager.Instance.eatingNoise.Play();
        Destroy(gameObject);
    }
}
