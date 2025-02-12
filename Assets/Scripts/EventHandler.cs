using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class EventHandler : MonoBehaviour
{
    [SerializeField]
    GameObject credits;
    [SerializeField]
    GameObject ventana;

    void OnEnable()
    {
        Button playButton = GetComponent<UIDocument>().rootVisualElement.Q("PlayButton") as Button;
        playButton.clicked += StartGame;
        Button creditButton = GetComponent<UIDocument>().rootVisualElement.Q("CreditButton") as Button;
        creditButton.clicked += ChangeCredits;
        Button exitButton = GetComponent<UIDocument>().rootVisualElement.Q("ExitButton") as Button;
        exitButton.clicked += ExitGame;
        Button accesButton = GetComponent<UIDocument>().rootVisualElement.Q("AccesButton") as Button;
        accesButton.clicked += AparecerVentana;
    }

    void StartGame()
    {
        gameObject.SetActive(false);
        ventana.SetActive(false);
    }

    void ChangeCredits()
    {
        gameObject.SetActive(false);
        ventana.SetActive(false);
        credits.SetActive(true);
    }

    void AparecerVentana()
    {
        ventana.SetActive(true);
    }

    void ExitGame()
    {
        Application.Quit();
    }

  
}

