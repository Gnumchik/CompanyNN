using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPartsSpawner : MonoBehaviour
{
    private ObsticalActivator _obsticalActivator = new ObsticalActivator();
    public void RandomSpawn(int level, LevelPartView[] levelPartViews, Transform spawnPosition, FinichLineView finichLineView)
    {
        LevelPartView startLevel = Object.Instantiate(levelPartViews[Random.Range(10, 100)], spawnPosition);
        _obsticalActivator.RandomActivation(startLevel);
            LevelPartView levelPart = Object.Instantiate(levelPartViews[Random.Range(10, 100)], spawnPosition);
            levelPart.transform.position = startLevel.LevelPartEnd1.position;
            startLevel = levelPart;
            _obsticalActivator.RandomActivation(startLevel);
    }
}
