using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI; // Para acceder al Slider

public class Volumen : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider volumenSlider; // Referencia al Slider de volumen

    private void Start()
    {
        // Cargar el volumen guardado al iniciar
        float volumenGuardado = PlayerPrefs.GetFloat("Volumen");
        volumenSlider.value = volumenGuardado;
        audioMixer.SetFloat("Volumen", volumenGuardado);
    }

    public void VolumenSlider(float volumen)
    {
        // Actualizar el volumen en el AudioMixer y guardar el cambio
        audioMixer.SetFloat("Volumen", volumen);
        PlayerPrefs.SetFloat("Volumen", volumen);
    }
}
