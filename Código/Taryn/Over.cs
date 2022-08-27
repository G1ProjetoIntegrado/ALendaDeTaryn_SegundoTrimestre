using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Over : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider) // manipulação do componente colisor da Unity
    {
        if(collider.gameObject.layer == 7) //confere se a Taryn colidiu com o Poseidon
        {
            Destroy(gameObject); //morte do Poseidon
        }
    }
}
