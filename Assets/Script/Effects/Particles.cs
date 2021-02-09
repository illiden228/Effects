using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    private ParticleSystemRenderer PSR;
    private float InputX;

    private void Start()
    {
        PSR = GetComponent<ParticleSystemRenderer>();
    }

    private void Update()
    {
        InputX = Input.GetAxis("Horizontal");

        if (InputX > 0)
            PSR.flip = new Vector3(1, 0, 0);
        else if (InputX < 0)
            PSR.flip = new Vector3(0, 0, 0);
    }
}
