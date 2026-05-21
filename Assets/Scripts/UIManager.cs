using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;

    void Start()
    {
        //poner el score en cero
        UpdateScore(0);
    
    }

    public void UpdateScore(int score)
    {
        //actualizar el texto score
        txtScore.text = score.ToString();
    }
}
