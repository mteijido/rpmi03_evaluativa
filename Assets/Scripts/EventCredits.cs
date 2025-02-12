using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EventCredits : MonoBehaviour
{

    [SerializeField]
    GameObject inicio;

    void OnEnable()
    {
        Button playButton = GetComponent<UIDocument>().rootVisualElement.Q("PlayButton") as Button;
        playButton.clicked += StartGame;
        Button inicioButton = GetComponent<UIDocument>().rootVisualElement.Q("InicioButton") as Button;
        inicioButton.clicked += ChangeInicio;
        Button exitButton = GetComponent<UIDocument>().rootVisualElement.Q("ExitButton") as Button;
        exitButton.clicked += ExitGame;
    }


    void StartGame()
    {
        gameObject.SetActive(false);
    }

    void ChangeInicio()
    {
        gameObject.SetActive(false);
        inicio.SetActive(true);
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
