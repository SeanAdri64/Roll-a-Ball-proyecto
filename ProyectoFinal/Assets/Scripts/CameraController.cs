using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //vector es para la posicion de la camara
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //distancia entre camara(transform.position) y jugador(playeer.transform.position)
        offset=transform.position-player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //LateUpdate sigue camara,animaciones procedimentalesy determinar ultimos estados conocidos de un objeto
    void LateUpdate(){
        transform.position = player.transform.position + offset;
    }
}
