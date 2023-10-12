using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalActivator : MonoBehaviour
{
    public void RandomActivation(LevelPartView levelPartView)
    {
        for (int i = 0; i < 3; i++)
        {
            levelPartView.AObsticleViews[Random.Range(1, levelPartView.AObsticleViews.Length)].gameObject.SetActive(true);
        }
    }
}
