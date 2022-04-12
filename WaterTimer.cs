using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTimer : MonoBehaviour
{ 
    public bool isWet = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        startTimer();
    }


    public void startTimer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isWet = true;
        
            StartCoroutine(timerDelay());
        }
    }

    IEnumerator timerDelay()
    {
        yield return new WaitForSeconds(5);
        isWet = false;
    }


}
