using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMngr : MonoBehaviour
{

    [SerializeField] Transform playerTransform;
    [SerializeField] Text scoreText;
    private float score = 0f;
    [SerializeField] float extra = 0f;

    void Update()
    {
        score = playerTransform.position.z + extra;
        scoreText.text = score.ToString("0");   
    }

    public void AddBonus(float bonus)
    {
        extra += bonus;
    }
}
