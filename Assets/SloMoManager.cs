using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SloMoManager : MonoBehaviour
{

    public float slowDownMeter = 0.1f;
    public float slowDownCounter = 3f;

    void Update()
    {
        Time.timeScale += (1f / slowDownCounter) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }
    public void SlowCar()
    {
        Time.timeScale = slowDownMeter;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
