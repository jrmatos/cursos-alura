using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour
{

    [SerializeField] private GameObject torrePrefab;
    
    void Update()
    {
        if (ClicouComBotaoPrimario())
        {
            ConstroiTorre();
        }
    }
    
    private bool ClicouComBotaoPrimario()
    {
        return Input.GetMouseButtonDown(0);
    }

    private void ConstroiTorre()
    {
        Vector3 posicaoDoClick = Input.mousePosition;
        RaycastHit elementoAtingidoPeloRaio = DisparaRaioDaCameraAteUmPonto(posicaoDoClick);

        if (elementoAtingidoPeloRaio.collider != null)
        {
            Vector3 posicaoDeCriacaoDaTorre = elementoAtingidoPeloRaio.point;
            Instantiate(torrePrefab, posicaoDeCriacaoDaTorre, Quaternion.identity);
        }
    }

    private RaycastHit DisparaRaioDaCameraAteUmPonto(Vector3 pontoInicial)
    {
        Ray raio = Camera.main.ScreenPointToRay(pontoInicial);
        RaycastHit elementoAtingidoPeloRaio;
        float compromentoMaximoDoRaio = 100.0f;
        Physics.Raycast(raio, out elementoAtingidoPeloRaio, compromentoMaximoDoRaio);

        return elementoAtingidoPeloRaio;
    }
}
