using UnityEngine;

[System.Serializable]
public struct EnvironmentSettings
{
    public bool enabled;
    public Color groundColour;
    public Color skyColourHorizon;
    public Color skyColourZenith;
    public float sunFocus;
    public float sunIntensity;
}

[System.Serializable]
public struct FoggSettings
{
    public bool enabled;
    public float visibilityDistance;
    public Color foggColour;
    public Color foggEmissionColour;
    public Color foggSpecularColour;
    public float foggEmissionStrength;
    public float foggSmoothness;
    public float foggSpecularProbability;
    public float foggHeightBias;
    public float foggHeight;
}