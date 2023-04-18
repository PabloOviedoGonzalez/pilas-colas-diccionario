using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dicccionary : MonoBehaviour
{

    Dictionary<string, char> diccionario;
    // Start is called before the first frame update
    void Start()
    {
        diccionario = new Dictionary<string, char>();
        diccionario.Add("Euro", '€');
        diccionario.Add("Dollar", '$');
        diccionario.Add("Yen", '¥');

        Debug.Log(diccionario["Dollar"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
