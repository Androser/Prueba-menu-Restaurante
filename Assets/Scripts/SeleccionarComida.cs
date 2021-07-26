using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarComida : MonoBehaviour
{
    public int _Menú;
    public int CantidadDeAlimentos;
    public int SegundoConteoDeAlimentos;
    public  GameObject[] ListadodeAlimentos;
    void Start ( )
    {
        foreach ( GameObject z in FindObjectsOfType<GameObject> ( ) )
        {
            if ( z.tag == "Comidaaa" )
            {
                CantidadDeAlimentos++;
            }
        }
        ListadodeAlimentos = new GameObject[CantidadDeAlimentos];

        foreach ( GameObject z in FindObjectsOfType<GameObject> ( ) )
        {
            if ( z.tag == "Comidaaa" )
            {

                ListadodeAlimentos[SegundoConteoDeAlimentos] = z.gameObject;
                SegundoConteoDeAlimentos++;

            }

        }
        foreach ( GameObject z in ListadodeAlimentos )
        {
            z.gameObject.SetActive ( false );
        }
        }
        public void Seleccionar (GameObject ObjetoPedido )
    {
        //En este apartado selecionamos la comida del menú
        foreach ( GameObject z in FindObjectsOfType<GameObject> ( ) )
        {
            if ( z.tag == "ObjetoDelMenú" )
            {
                z.GetComponent<Animator> ( ).Play ( "Bajar Menú" );
            }
        }
        ObjetoPedido.GetComponent<Animator> ( ).Play ( "Levantar Menú" );

        //

        //En este apartado seleccionamos la comida 3D
        foreach ( GameObject z in ListadodeAlimentos )
        {
                z.gameObject.SetActive ( false );

                string sa = ObjetoPedido.name + " C";
                Debug.Log ( sa );
                if ( z.name == sa )
                {
                    z.gameObject.SetActive ( true );
                }
        }
    }
}