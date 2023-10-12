using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private LevelPartView[] _levelPartViews;
    [SerializeField] private FinichLineView _finichLineView;
    private LevelPartsSpawner _partSpawner = new LevelPartsSpawner();
    void Start()
    {
        _partSpawner.RandomSpawn(PlayerPrefs.GetInt("level", 1), _levelPartViews, transform, _finichLineView);
    }
}
