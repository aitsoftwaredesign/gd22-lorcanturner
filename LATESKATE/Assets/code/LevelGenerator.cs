using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200F;

    [SerializeField] private Transform FloorStart;
    [SerializeField] private Transform Floor;
    [SerializeField] private Transform player;

    private Vector3 lastEndPosition;
    private void Awake()
    {
        lastEndPosition = FloorStart.Find("EndPosition").position;
        SpawnLevelPart();
        int i = 0;
        for(i = 0; i <= 40; i++)
        {
            SpawnLevelPart();
        }
       
    }

    private void SpawnLevelPart()
    {
      Transform lastFloorTransform = SpawnLevelPart(lastEndPosition);
      lastEndPosition = lastFloorTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
       Transform FloorTransform = Instantiate(Floor, spawnPosition, Quaternion.identity);
        return FloorTransform;
    }
}
