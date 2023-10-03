using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] gameObjects;
    int gameobjectIndex;
    public int index;
    private void Awake()
    {
        for (gameobjectIndex = 0; gameobjectIndex <= 5; gameobjectIndex++)
            gameObjects[gameobjectIndex].SetActive(false);
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            OpenGameObject(index);
        if (Input.GetKey(KeyCode.S))
            ActiveGameObject(index, true);
    }
    public void OpenGameObject(int index)
    {
        if (index >= gameObjects.Length)
            return;
        gameObjects[index].SetActive(true);
    }
    public void ActiveGameObject(int index,bool active=true)
    {
        if (active)
            gameObjects[index].SetActive(true);
        else
            return;
    }
}
