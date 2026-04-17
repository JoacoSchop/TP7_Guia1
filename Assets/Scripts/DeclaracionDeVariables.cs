using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    public string variableString = "hola Jero";
    public bool variableBool = true;
    public int variableInt = 12;
    public float variableFloat = 12.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(variableBool);
        Debug.Log(variableFloat);
        Debug.Log(variableString);
        Debug.Log(variableInt);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
