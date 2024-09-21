using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int totalScore = 0;  //Para el conteo de puntos

    [SerializeField] private TextMeshProUGUI scoreText;
    private void OnEnable()
    {
        EventManager.OnEnemyKilled += AddPoints;  //Subscribirse al evento cuando un enemigo es destruido
    }

    private void OnDisable()
    {        
        EventManager.OnEnemyKilled -= AddPoints;
    }

    //Método para agregar puntos cuando un enemigo es destruido
    private void AddPoints(int scoreValue)
    {
        totalScore += scoreValue;
        UpdateScoreUI();
    }

    //Para actualizar el texto de los puntos en la UI
    private void UpdateScoreUI()
    {
        scoreText.text = totalScore.ToString();
    }
}
