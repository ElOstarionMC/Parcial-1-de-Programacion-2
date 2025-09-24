using System;
using NUnit.Framework;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    private static ScreenController instance;
    public static ScreenController Instance => instance;
    // [SerializeField] float multiplier = 0.80f;
    private static Vector2 randomInScreenPosition;
    private static float inScreenX = 0;
    private static float inScreenY = 0;
    private static float maxInScreenY = 3.5f;
    private static float maxInScreenX = 7.5f;

    
    private static Vector2 randomOutScreenPosition;
    private static float outScreenX = 0;
    private static float outScreenY = 0;


    // min values
    // x: -9
    // y:-5
    // max values
    // x: 9
    // y: 5

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // In Screen
    private float getRandomInScreenX()
    {
        inScreenX = UnityEngine.Random.Range(-maxInScreenX, maxInScreenX);
        inScreenX = Math.Clamp(inScreenX, -maxInScreenX, maxInScreenX);
        return inScreenX;
    }

    private float getRandomInScreenY()
    {
        inScreenY = UnityEngine.Random.Range(-maxInScreenY, maxInScreenY);
        inScreenY = Math.Clamp(inScreenY, -maxInScreenY, maxInScreenY);
        return inScreenY;
    }

    public Vector2 getRandomInScreenPosition()
    {
        randomInScreenPosition = new Vector2(getRandomInScreenX(), getRandomInScreenY());
        return randomInScreenPosition;
    }

    // Out Screen
    private float getRandomOutScreenX()
    {
        bool left = UnityEngine.Random.value < 0.5f;

        if (left)
        {
            outScreenX = UnityEngine.Random.Range(-maxInScreenX * 2f, -maxInScreenX);
            return outScreenX;
        }
        else
        {
            outScreenX = UnityEngine.Random.Range(maxInScreenX, maxInScreenX * 2f);
            return outScreenX;
        }
    }

    private float getRandomOutScreenY()
    {
        bool bottom = UnityEngine.Random.value < 0.5f;

        if (bottom)
        {
            
            outScreenY = UnityEngine.Random.Range(-maxInScreenY * 2f, -maxInScreenY);
            return outScreenY;
        }
        else
        {
            outScreenY = UnityEngine.Random.Range(maxInScreenY, maxInScreenY * 2f);
            return outScreenY;
        }
    }

    public Vector2 getRandomOutScreenPosition()
    {
        randomOutScreenPosition = new Vector2(getRandomOutScreenX(), getRandomOutScreenY());
        return  randomOutScreenPosition;
    }
}
