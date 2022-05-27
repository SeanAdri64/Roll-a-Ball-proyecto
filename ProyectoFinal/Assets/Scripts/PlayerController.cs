using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Transform particulas;
    private ParticleSystem sistemaParticulas;
    private Vector3 posicion;
    private int puntos;
    bool pausado=false;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hola Mundo!!");  
        rb=GetComponent<Rigidbody> ();
        sistemaParticulas=particulas.GetComponent<ParticleSystem>();
        sistemaParticulas.Stop();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void FixedUpdate(){
        float moveHorizontal=Input.GetAxis("Horizontal");
        float moveVertical=Input.GetAxis("Vertical");
        Vector3 movimiento =new Vector3(moveHorizontal,0.0f, moveVertical);
        rb.AddForce(movimiento*speed);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Recolectable")){
            //objeto other con el que acabamos de colisionar
            posicion =other.gameObject.transform.position;
            particulas.position=posicion;
            sistemaParticulas=particulas.GetComponent<ParticleSystem>();
            sistemaParticulas.Play();
            other.gameObject.SetActive(false);
            //el objeto es recolectable
            puntos++;
        }else{
            //el objeto No es recolectable
            if(other.gameObject.CompareTag("villano")){
                Debug.Log("Has perdido,puntos evita las capsulas rojas"); 
                other.gameObject.SetActive(false);
                puntos--;

            }else{
                if(other.gameObject.CompareTag("trap")){
                    Debug.Log("Oops caiste en una trampa"); 
                    other.gameObject.SetActive(false);
                }else{

                }         
            }
        }

    }

    void OnGUI(){
        GUI.Box( new Rect(0,0,80,35), "Score: "+ puntos);

        if (puntos==14){
                Debug.Log("Has ganado!!");
                
                pausado=true;
        
                Time.timeScale=0;

        }else{
                if(puntos==-1){
                    puntos+=1;
                }else{
                    if( pausado){
                        Time.timeScale=1;
                        pausado= false;
                    }else{

                    }
                }
        }
    }
               
}
