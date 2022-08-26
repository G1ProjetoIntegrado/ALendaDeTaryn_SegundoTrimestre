using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    void Update()
    {
        Vector3 Power = new Vector3(-1f, 0f, 0f); //Vetor de movimento para o poder do Poseidon (ultilizando o eixo x)
        transform.position += Power * Time.deltaTime * Speed; // movimentação do personagem ultilizando o verto e a variável de velocidade
    }
}
