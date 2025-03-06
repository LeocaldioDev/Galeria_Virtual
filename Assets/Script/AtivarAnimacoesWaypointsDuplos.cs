using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarAnimacoesWaypointsDuplos : MonoBehaviour
{
    public Animator animatorWaypointSubir;
    public Animator animatorWaypointDescer;



    private void OnDisable()
    {
        if (animatorWaypointSubir != null && animatorWaypointDescer != null)
        {
            animatorWaypointSubir.SetBool("subir", true);
            animatorWaypointDescer.SetBool("descer", true);
            animatorWaypointDescer.SetBool("subir", false);
            animatorWaypointSubir.SetBool("descer", false);
        }
    }
}