using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poseidon_Move : MonoBehaviour
{
    float speed = 5; //variável de velocidade para o Poseidon
    bool baixo = true; //variável que declara a direção (ele vai começar sempre para cima)
    bool cima = false; //variável que declara a direção
    // Start is called before the first frame update
    SpriteRenderer spriteRenderer; //variável para renderizar o inimigo 
    Animator anim; //variavel de animação
    void Start()
    {
        anim = GetComponent<Animator>(); //Componente de Animação para ser utilizado na Unity.
        spriteRenderer = GetComponent<SpriteRenderer>(); //componente de sprite para ser ultilizado na Unity
    }

    // Update is called once per frame
    void Update()
    {
       if (cima == true) // confere se ele está na direção correta 
       {
        anim.SetBool("Move",true); //traz a animação de movimento do Poseidon
        transform.position = transform.position + (Vector3.up * speed * Time.deltaTime); //movimentação do Poseidon ultilizando o vetor
        if(transform.position.y > 3.60) // confere se ele chegou no ponto máximo do cenário
        {
            cima = false; //declatra que ele chegou no ponto máximo 
            baixo = true; //muda a direção para baixo
        }
       }

       if(baixo == true) // confere se ele está na direção correta 
       {
        anim.SetBool("Move",true);  //traz a animação de movimento do Poseidon
        transform.position = transform.position + (Vector3.down * speed * Time.deltaTime); //movimentação do Poseidon ultilizando o vetor
        if(transform.position.y <- 3.47) //declatra que ele chegou no ponto minimo
        {
            cima = true; //muda a direção para cima 
            baixo = false; //declatra que ele chegou no ponto máximo
        }
       }
       
    }
}
