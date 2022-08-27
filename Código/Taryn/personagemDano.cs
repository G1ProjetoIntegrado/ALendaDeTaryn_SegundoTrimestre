using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class personagemDano : MonoBehaviour
{
    public int vidaAtual = 3; //variável de vida da Taryn

    public void ReceiveAtackk ()
    {
        vidaAtual -= 1; //tira 1 da vida

        if(vidaAtual <= 0) //se a vida for menor ou igual a 0
        {
            Debug.Log("Game Over"); //imprime o gameOver no console 
            Debug.Log(vidaAtual); //imprime a vida da Tarun no console 
            Destroy(gameObject); // morte da Taryn
            vidaAtual = 0; // garante que a vida não vai diminuir
        }
    }
}
