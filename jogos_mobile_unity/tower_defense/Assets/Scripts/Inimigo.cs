using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NavMeshAgent agente = GetComponent<NavMeshAgent>();
		GameObject fimDoCaminho = GameObject.Find("FimDoCaminho");
		Vector3 posicaoDoFimDoCaminho = fimDoCaminho.transform.position;
		agente.SetDestination(posicaoDoFimDoCaminho);
	}

}
