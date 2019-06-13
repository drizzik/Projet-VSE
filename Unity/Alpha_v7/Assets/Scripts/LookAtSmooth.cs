using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSmooth : MonoBehaviour
{
    [Tooltip("[0] = Left, [1] = Middle, [2] = Right")]
    public List<GameObject> targets; // [0] = Left, [1] = Middle, [2] = Right

    public int speed = 5;
    public float tenSec = 3;

    private bool timerRunning = false;

    int currentPosition; // 0 = Left, 1 = Middle, 2 = Right
    bool direction;

    public void Start()
    {
        currentPosition = 1; // Initial position = Middle
    }

    public void Update()
    {
        if (timerRunning)
        {
            tenSec -= Time.smoothDeltaTime;
            if (tenSec >= 0)
            {
                Quaternion targetRotation = Quaternion.LookRotation(targets[currentPosition].transform.position - transform.position);

                // Smoothly rotate towards the target point.
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
            }
            else
            {

                timerRunning = false;
                tenSec = 3;
            }

        }
    
}

    public void smoothRotate(bool _direction) // 0 = gauche, 1 = droite
    {
        direction = _direction;
        timerRunning = true;
        //target = targetObj;
        tenSec = 3;

        if (!direction) // If direction == Left
        {
            if (currentPosition > 0 && currentPosition <= 2) // If position == Middle or Right
            {
                currentPosition--;
            }
        }
        else if (direction) // If direction == Right
        {
            if (currentPosition >= 0 && currentPosition < 2) // If position == Left or Middle
            {
                currentPosition++;
            }
        }
    }
}



