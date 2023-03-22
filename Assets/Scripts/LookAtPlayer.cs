using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LookAtPlayer : MonoBehaviour
{
    GameObject MainCam;
    
    private void Start()
    {
        MainCam = GameObject.Find("Main Camera");
    }
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - MainCam.transform.position);
    }
}
