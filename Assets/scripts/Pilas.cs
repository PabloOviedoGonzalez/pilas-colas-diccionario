using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilas : MonoBehaviour
{

    //con un while hay q hacer pop de la pila origen, meter ese pop en la variable aux y hacer push de el valor de
    //aux en la pilaAux. Despues al repetir el proceso en el momento en el q se vaya a hacer el push de aux a la 
    //pilaAux hay q comprobar si el numero q esta ya en la pilaAux es menor q el q le llega en la variable, si NO
    // es menor, se hace push de el valor de aux en la pilaAux y si SI es menor, hay q hacer pop del numero peek
    // de la pilaAux a la pilaOrigin y despues volver a comprobar se el peek de la pilaAux es menor q aux. Este 
    //proceso se repite hasta q la condicion de q la pilaOrigin q dice q tenga datos sea falso y se acaba ordenando
    //en la pilaAux. Pero ns hacerlo.
    int aux;
    //Stack<int> pilaAux;

    // Start is called before the first frame update
    void Start()
    {
        Stack<int> pilaOrigin = new Stack<int>();
        pilaOrigin.Push(4);
        pilaOrigin.Push(-5);
        pilaOrigin.Push(-10);
        pilaOrigin.Push(88);
        pilaOrigin.Push(2);

        Stack<int> pilaAux = new Stack<int>();

        int count = pilaOrigin.Count;
        while (count >= 0 )
        {
            aux = pilaOrigin.Pop();
            while (pilaAux.Count == 0 || pilaAux.Peek() < aux)
            {
                //if (true)
                //{
                //    pilaAux.Push(aux);

                //}
                //else if (false)
                //{

                //}

                pilaAux.Push(aux);

            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
