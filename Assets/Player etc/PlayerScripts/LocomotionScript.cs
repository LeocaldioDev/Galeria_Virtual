using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionScript : MonoBehaviour
{

    public Transform player;
    public AudioSource SomTeleport;
    public float tempoDelay = 2f;
    public List<GameObject> waypoints = new List<GameObject>();
    public Animator portaAnim;
    public GameObject PainelActivar;
    private bool contandoTempo = false;
    private Coroutine coroutineTeletransporte;



    private IEnumerator TeletransportarComDelayCoroutine()
    {
        yield return new WaitForSeconds(tempoDelay);
        Teletransportar();


        for (int i = 0; i < waypoints.Count; i++)
        {
            waypoints[i].SetActive(true);
        }

        PainelActivar.SetActive(true);

        portaAnim.SetBool("abrir", true);


        gameObject.SetActive(false);

        SomTeleport.Play();

        contandoTempo = false;
    }

    private void Teletransportar()
    {
        Vector3 novaPosicao = transform.position;
        novaPosicao.y = transform.position.y + 1.90f;
        player.position = novaPosicao;


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

    public IEnumerator DesativarPainelAposTempo()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("ola por aqui!");
        PainelActivar.SetActive(false);
    }
}