using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerComida : MonoBehaviour
{
    public GameObject[] _Menú;

    public void AparecerMenú (int x )
    {
        foreach(GameObject z in _Menú )
        {
            z.SetActive ( false );
        }
        _Menú[x].SetActive ( true );
    }
}
