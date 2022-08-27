using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{
    public float Speed; //variável de velocidade para personagem principal
    Animator anim; //variavel de animação
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); //Componente de Animação para ser utilizado na Unity.
    }

    // Update is called once per frame
    void Update()
    {
     Move(); //Chama a função executando ela frame a frame.(loop)
    }
    void Move()
    {
       Vector3 Movimento = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f); //Vetor de movimento para a personagem principal (ultilizando o eixo x)
        transform.position += Movimento * Time.deltaTime * Speed; // movimentação do personagem ultilizando o vetor e a variável de velocidade

        if(Input.GetAxis("Horizontal")>0f) // conferindo se o eixo X foi pressionado e comparando se houve ou não uma variação
        {
          anim.SetBool("Move",true); // caso o eixo X>0 ele vai puxar a animação para o lado direito
        }
        if(Input.GetAxis("Horizontal")<0f) 
        {
          anim.SetBool("Move", true);// caso o eixo X<0 ele vai puxar a animação para o lado esquerda
        }
        if(Input.GetAxis("Horizontal") == 0f) 
        {
          anim.SetBool("Move", false); // caso o eixo X=0 ele declara que a animação é falsa e continua a animação  idle
        }

        float inputAxis = Input.GetAxis("Horizontal");//declara variável para associar o acionamento da tecla do eixo X  
        if(inputAxis > 0) //caso o eixo X>0
        {
          transform.eulerAngles = new Vector2(0f, 0f); //a taryn se mantém à direita 
        }
        if(inputAxis < 0) //caso o eixo X<0
        {
          transform.eulerAngles = new Vector2(0f, 180f); // vira para a esquerda
        }
    }
}
