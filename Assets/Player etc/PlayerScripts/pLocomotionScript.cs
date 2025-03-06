using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pLocomotionScript : MonoBehaviour
{

    public Transform player;
    public Transform euWaypoint;
    public GameObject euWaypointe;
    public float tempoDelay = 2f;
    public List<GameObject> waypoints = new List<GameObject>();
    private bool contandoTempo = false;
    private Coroutine coroutineTeletransporte;
    public AudioSource audioDoProduto;
    public Animator animacaoFuncionario;
    public bool verificarPosicao;


    public void apresentacao()
    {
        audioDoProduto.Play();
        StartCoroutine(WaitForAudioEnd());
        if (audioDoProduto.isPlaying)
        {
            animacaoFuncionario.SetBool("falar", true);
            animacaoFuncionario.SetBool("idle", false);
        }

    }


    IEnumerator WaitForAudioEnd()
    {
        yield return new WaitForSeconds(audioDoProduto.clip.length);
        animacaoFuncionario.SetBool("idle", true);
        animacaoFuncionario.SetBool("falar", false);
    }

    private IEnumerator TeletransportarComDelayCoroutine()
    {
        yield return new WaitForSeconds(tempoDelay);
        Teletransportar();
        euWaypointe.SetActive(false);
        for (int i = 0; i < waypoints.Count; i++)
        {
            waypoints[i].SetActive(true);
        }

        apresentacao();
        contandoTempo = false;
    }

    private void Teletransportar()
    {
        float posY = player.position.y;
        Vector3 novaPosicao = euWaypoint.position;
        novaPosicao.y = posY;
        player.position = novaPosicao;
        verificarPosicao = true;

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
