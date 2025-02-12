using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EventVentana : MonoBehaviour
{
    [SerializeField]
    GameObject inicio;
    [SerializeField]
    Texture2D fondoInicio;
    void OnEnable()
    {
        Button cerrarButton = GetComponent<UIDocument>().rootVisualElement.Q("CerrarButton") as Button;
        cerrarButton.clicked += CloseVentana;
        Button disminuirTamanoButton = GetComponent<UIDocument>().rootVisualElement.Q("DisminuyeTMButton") as Button;
        disminuirTamanoButton.clicked += DisminuirTx;
        Button aumentarTamanoButton = GetComponent<UIDocument>().rootVisualElement.Q("AumentaTMButton") as Button;
        aumentarTamanoButton.clicked += AumentarTx;
        Toggle toggle = GetComponent<UIDocument>().rootVisualElement.Q("CambiarContrasteToggle") as Toggle;
        toggle.RegisterValueChangedCallback(ChangeContraste);
    }

    
    void CloseVentana()
    {
        gameObject.SetActive(false);
    }

    void DisminuirTx()
    {
        inicio.GetComponent<UIDocument>().rootVisualElement.Q("PlayButton").style.fontSize = 56;
        inicio.GetComponent<UIDocument>().rootVisualElement.Q("CreditButton").style.fontSize = 56;
        inicio.GetComponent<UIDocument>().rootVisualElement.Q("ExitButton").style.fontSize = 56;
;
    }

    void AumentarTx()
    {
        inicio.GetComponent<UIDocument>().rootVisualElement.Q("PlayButton").style.fontSize = 70;
        inicio.GetComponent<UIDocument>().rootVisualElement.Q("CreditButton").style.fontSize = 70;
        inicio.GetComponent<UIDocument>().rootVisualElement.Q("ExitButton").style.fontSize = 70;
    }

    void ChangeContraste(ChangeEvent<bool> evt)
    {
        if (evt.newValue)
        {
            VisualElement background = inicio.GetComponent<UIDocument>().rootVisualElement.Q("Background");
            background.style.backgroundImage = null;
            background.style.backgroundColor = Color.black;
        }
        else
        {
            VisualElement background = inicio.GetComponent<UIDocument>().rootVisualElement.Q("Background");
            background.style.backgroundImage = new StyleBackground(fondoInicio);
        }        
    }
}
