using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalReached : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Male_01_V02")
        {
            GameManager.Instance.goalreached();
        }
        //GameManager.Instance.goalreached();
    }
}
