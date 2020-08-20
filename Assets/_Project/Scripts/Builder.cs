using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    public BuildingType currentBuildingType;

    public Extractor extractorPrefab;

    private void Awake()
    {
        currentBuildingType = BuildingType.None;
    }

    public void SetNoneBuildingMode()
    {
        SetBuilderMode(BuildingType.None);
    }

    public void SetExtractorBuildingMode()
    {
        SetBuilderMode(BuildingType.Extractor);
    }

    public void SetBuilderMode(BuildingType buildingType)
    {
        currentBuildingType = buildingType;
    }

    public void Build(Vector2 position)
    {
        if (currentBuildingType == BuildingType.None) return;

        switch (currentBuildingType)
        {
            case BuildingType.Extractor:
                BuildExtractor(position);
                break;
        }
    }

    private void BuildExtractor(Vector2 position)
    {
        Instantiate(extractorPrefab, position, Quaternion.identity);
    }
}
