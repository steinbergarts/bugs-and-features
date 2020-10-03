using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){ //Вказуємо що скрипт застосовується коли 2д колайдер взаємодіє з чимось іншим
        Destroy (gameObject); // кажемо що об'єкут з яким взаємодіє наш об'єкт знищується
    }
}
