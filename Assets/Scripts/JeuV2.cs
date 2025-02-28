using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;

    public int pointsJeu = 0;
    public int temps = 0;

    void Start()
    {
        pointsJeu = 0;
        InvokeRepeating("AugmenterTemps", 0f, 1f);
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
    }

    public void AugmenterTemps()
    {
        temps++;
        _etiquettePoints.text = temps.ToString();
    }
}
