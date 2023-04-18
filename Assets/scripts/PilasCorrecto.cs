using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilasCorrecto : MonoBehaviour
{

    Stack<int> pilaOrigin;

    //con un while hay q hacer pop de la pila origen, meter ese pop en la variable aux y hacer push de el valor de
    //aux en la pilaAux. Despues al repetir el proceso en el momento en el q se vaya a hacer el push de aux a la 
    //pilaAux hay q comprobar si el numero q esta ya en la pilaAux es menor q el q le llega en la variable, si NO
    // es menor, se hace push de el valor de aux en la pilaAux y si SI es menor, hay q hacer pop del numero peek
    // de la pilaAux a la pilaOrigin y despues volver a comprobar se el peek de la pilaAux es menor q aux. Este 
    //proceso se repite hasta q la condicion de q la pilaOrigin q dice q tenga datos sea falso y se acaba ordenando
    //en la pilaAux. Pero ns hacerlo.

    //Stack<int> pilaAux;

    // Start is called before the first frame update
    void Start()
    {
        pilaOrigin = new Stack<int>();


        pilaOrigin.Push(4);
        pilaOrigin.Push(-5);
        pilaOrigin.Push(-10);
        pilaOrigin.Push(88);
        pilaOrigin.Push(2);


        OrdenarPila();
    }


    void OrdenarPila()
    {
        Stack<int> pila1, pila2;
        pila1 = new Stack<int>();
        pila2 = new Stack<int>();



        while(pilaOrigin.Count > 0)
        {
            int numero = pilaOrigin.Pop();
            pila1.Push(numero);
        }

        while (pila1.Count > 0)
        {
            int aux = pila1.Pop();
            while (pila1.Count > 0)
            {
                int val = pila1.Pop();

                if (val > aux)
                {
                    pila2.Push(aux);
                    aux = val;
                }
                else
                {
                    pila2.Push(val);
                }
            }

            //aux es el mayor numero de todos
            pilaOrigin.Push(aux);

            //swap
            Stack<int> pilaAux = pila1;
            pila1 = pila2;
            pila2 = pilaAux;
        }
    }


   

    
}


