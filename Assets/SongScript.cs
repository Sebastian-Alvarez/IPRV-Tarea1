using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SongScript : MonoBehaviour
{
    public AudioClip[] songsArray;
    AudioSource soundSource;
    public int contador;
    public TextMeshProUGUI tmp;
    public Slider volumenSlider;

    private void Start(){
        soundSource = GetComponent<AudioSource>();
        contador = 0;
        soundSource.clip = songsArray[contador];
    }
    private void Update()
    {
        tmp.text = soundSource.clip.name;
        soundSource.volume = volumenSlider.value;
    }

    public void Play()
    {
        if (!soundSource.isPlaying)
        {
            soundSource.Play();
        }
    }
    public void Stop()
    {
        soundSource.Pause();
    }

    public void Next()
    {
        contador++;
        if(contador >songsArray.Length-1)
        {
            contador = 0;
        }
        soundSource.clip = songsArray[contador];
        soundSource.Play();
    }
    public void Previous()
    {
        contador--;
        if (contador<0)
        {
            contador = songsArray.Length-1;
        }
        soundSource.clip = songsArray[contador];
        soundSource.Play();
    }
    public void Exit()
    {
        Application.Quit();
    }
}
