using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarAnimacaoAoDesativar : MonoBehaviour
{
    public GameObject objetoComAnimacao;

    private void OnDisable()
    {
        if (objetoComAnimacao != null)
        {
            Animator animator = objetoComAnimacao.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("activar");
                animator.SetBool("fechar", false);


            }
        }
    }
}
