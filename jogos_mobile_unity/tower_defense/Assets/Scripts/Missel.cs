using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missel : MonoBehaviour
{
	[Range(0,5)]
	public float velocidade;
	private GameObject alvo;

	void Start()
	{
		alvo = GameObject.Find("Inimigo");
	}
	
	// Update is called once per frame
	void Update ()
	{
		Anda();
		AlteraDirecao();
	}
	
	private void AlteraDirecao()
	{
		Vector3 posicaoAtual = transform.position;
		
		Vector3 posicaoDoAlvo = alvo.transform.position;

		Vector3 direcaoDoAlvo = posicaoDoAlvo - posicaoAtual; 

		transform.rotation = Quaternion.LookRotation(direcaoDoAlvo);
	}

	private void Anda()
	{
		Vector3 posicaoAtual = transform.position;
		Vector3 deslocamento = transform.forward * Time.deltaTime * velocidade;
		transform.position = posicaoAtual + deslocamento;
	}
}
