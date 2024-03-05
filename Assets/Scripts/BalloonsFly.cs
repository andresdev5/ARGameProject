using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonsFly : MonoBehaviour
{

    float speed = 0.3f;

    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    public void IncreaseSpeed(float amount)
    {
        speed += amount;
    }
}

  
