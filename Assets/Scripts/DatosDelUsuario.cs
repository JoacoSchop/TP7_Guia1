using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombre = "Joaco";
    public int edad = 15;
    public float altura = 1.90f;
    public bool donante = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es "+ nombre + ", tengo " + edad + ", mido " + altura + " metros y es " + donante + " que soy donante de órganos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
