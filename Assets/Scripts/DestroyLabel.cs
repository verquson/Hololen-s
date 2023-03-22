using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLabel : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        Console.WriteLine("Amogus");
        if(other.gameObject.layer == 6)
        {
            Destroy(other.gameObject);
        }
    }
}
