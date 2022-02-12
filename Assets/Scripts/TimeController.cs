using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public float timeSens = 5f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale += timeSens;
        }
    }
}
