using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    [SerializeField] GameMngr gameMngr;
    [SerializeField] float rotationSpeed = 100f;
    [SerializeField] float bonus = 500f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameMngr.AddBonus(bonus);
    }
}
