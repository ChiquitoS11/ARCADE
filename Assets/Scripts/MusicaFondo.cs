using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    private AudioSource miMusica;
    [SerializeField] private int delayMusica;

    // Start is called before the first frame update
    void Start()
    {
        miMusica = GetComponent<AudioSource>();
        reproducirMusica(delayMusica);
    }

    public void reproducirMusica(int delayMusica)
    {
        miMusica.PlayDelayed(delayMusica);
    }

    // Update is called once per frame
    void Update()
    {
        if (!miMusica.isPlaying)
        {
            reproducirMusica(delayMusica);
        }
    }
}
