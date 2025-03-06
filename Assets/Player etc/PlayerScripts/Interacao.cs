using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao : MonoBehaviour
{
    public AudioSource SomInteracaoProd;
    public Animator animacaoFuncionario;
    public float tempoDelay = 2f;
    public GameObject Painel;
    public List<GameObject> PainelDesativar = new List<GameObject>();
    public AudioSource audioDoProduto;
    public List<AudioSource> audioDoProdutoEliminar = new List<AudioSource>();
    private bool contandoTempo = false;
    private Coroutine coroutineTeletransporte;
    public static pLocomotionScript pl = new pLocomotionScript();



    private IEnumerator TeletransportarComDelayCoroutine()
    {
        yield return new WaitForSeconds(tempoDelay);

        Painel.SetActive(true);
        SomInteracaoProd.Play();
        for (int i = 0; i < PainelDesativar.Count; i++)
        {
            PainelDesativar[i].SetActive(false);

        }

        audioDoProduto.Play();
        StartCoroutine(WaitForAudioEnd());
        for (int i = 0; i < audioDoProdutoEliminar.Count; i++)
        {
            audioDoProdutoEliminar[i].Stop();

        }

        if (audioDoProduto.isPlaying)
        {
            animacaoFuncionario.SetBool("falar", true);
            animacaoFuncionario.SetBool("idle", false);

        }



        contandoTempo = false;
    }
    IEnumerator WaitForAudioEnd()
    {
        yield return new WaitForSeconds(audioDoProduto.clip.length);
        animacaoFuncionario.SetBool("falar", false);
        animacaoFuncionario.SetBool("idle", true);
        Painel.SetActive(false);
    }


    public void TeletransportarFuncaoPrincipal()
    {
        coroutineTeletransporte = StartCoroutine(TeletransportarComDelayCoroutine());
    }

    public void CancelarTeletransporteFuncaoPrincipal()
    {
        if (coroutineTeletransporte != null)
        {
            StopCoroutine(coroutineTeletransporte);
            coroutineTeletransporte = null;
            Debug.Log("Teletransporte cancelado.");
        }
    }


}

