using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DestroyOverTime : MonoBehaviour
{
    public float lifetime = 1.5f;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
