using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{

	public GameObject projetilPrefab;
	public float tempoDeRecarga = 0.2f;
	private float momentoDoUltimoDisparo;
	private float tempoAtual;
	private GameObject alvo;

	void Start()
	{
		alvo = GameObject.Find("Inimigo");
	}

	// Use this for initialization
	void Update () {
		Atira();
		AlteraDirecao();
	}

	private void AlteraDirecao()
	{
		Vector3 posicaoAtual = transform.position;
		
		Vector3 posicaoDoAlvo = alvo.transform.position;

		Vector3 direcaoDoAlvo = posicaoDoAlvo - posicaoAtual; 

		transform.rotation = Quaternion.LookRotation(direcaoDoAlvo);
	}

	private void Atira()
	{
		tempoAtual = Time.time;
		if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga)
		{
			momentoDoUltimoDisparo = tempoAtual;
			GameObject pontoDeDisparo = this.transform.Find("CanhaoDaTorre/PontoDeDisparo").gameObject;
			Vector3 posicaoDoPontoDeDisparo = pontoDeDisparo.transform.position;
			Instantiate(projetilPrefab, posicaoDoPontoDeDisparo, Quaternion.identity);
		}
	}
}
