using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) // manipulação do componente colisor da Unity
    {
        if(other.gameObject.CompareTag("Player")) //confere se houve colisão do objeto com a Taryn
        {
            other.gameObject.GetComponent<personagemDano>().ReceiveAtackk(); //caso sim, Taryn perde uma vida
            Debug.Log(other.gameObject.GetComponent<personagemDano>().vidaAtual); //conta quantas vidas a Taryn tem 
            Destroy(gameObject); //destrói o objeto
        }
    }
}
