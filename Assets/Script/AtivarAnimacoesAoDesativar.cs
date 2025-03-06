using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarAnimacoesAoDesativar : MonoBehaviour
{
    public Animator animatorWaypoint;
    public Animator animatorPorta;

    private void OnDisable()
    {

        animatorWaypoint.SetBool("animar", true);
        animatorPorta.SetBool("fechar", true);
        animatorPorta.SetBool("activar", false);

    }
}