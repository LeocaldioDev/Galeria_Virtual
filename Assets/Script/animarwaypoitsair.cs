using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animarwaypoitsair : MonoBehaviour
{
    public Animator animatorWaypoint;


    private void OnDisable()
    {

        animatorWaypoint.SetBool("entrar", true);



    }
}
