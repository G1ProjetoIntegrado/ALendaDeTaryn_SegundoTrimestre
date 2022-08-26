using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulo : MonoBehaviour
{
    public float ForceJump; //declara variável ForceJump (a força do pulo da Taryn)
    private Rigidbody2D rig; //declara variável rig (para manipular a gravidade)
    public bool isJumping; //declara variável isJumping (para saber se a Taryn está em contato com o chão para pular)
    Animator anim;  //variavel de animação
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>(); //Componente de Animação para ser utilizado na Unity.
        anim = GetComponent<Animator>(); //Componente de Animação para ser utilizado na Unity.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isJumping == true) //se o botão espaço seja pressionado e a Taryn esteja em contato com o chão 
        {
            rig.AddForce(new Vector2(0f, ForceJump), ForceMode2D.Impulse); // adiciona força necessária para a Taryn pular 
            isJumping = false; // declara que a Taryn não está em contato com o chão 
            anim.SetBool("Jump", true); // traz a animação de pulo para a Taryn
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) // manipulação do componente colisor da Unity 
    {
        if(collision.gameObject.tag == "is Jumping") //confere se a Taryn está em contato com o chão 
        {
            isJumping = true; //declara que a Taryn está em contato com chão
            anim.SetBool("Jump", false); //declara que a animação é falsa e continua a animação  idle
        }
    }
}
