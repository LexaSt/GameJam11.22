using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletTime : MonoBehaviour
{
    [SerializeField] float _timeToForce = 2f;
    private float _currentTime;

    private void Update()
    {
        if (_currentTime >= 0f)
        {
            _currentTime -= Time.unscaledDeltaTime;       
        }
 
        if (Input.GetMouseButtonDown(0))
        {
            _currentTime = _timeToForce;
            
        }
        StopTime();
    }

    public void StopTime()
    {
        if (_currentTime >= 0)
        {
            Time.timeScale = 0.2f;
        }
        else if (_currentTime<=0)
        { 
            Time.timeScale = 1f;
        }       
    }

}
