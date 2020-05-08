using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Threepoint : MonoBehaviour
{
    public bool inthreepoint;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider")
        {
            inthreepoint = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "HeadCollider")
        {
            inthreepoint = false;
        }
    }
}
