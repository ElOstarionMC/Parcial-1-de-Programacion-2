using UnityEngine;

public class SMouseController : MonoBehaviour
{
    private static SMouseController instance;
    public static SMouseController Instance => instance;

    private bool isClickMaintained = false;
    private bool isClicked = false;
    private static Vector2 mousePosition;
    public static Vector2 MousePosition => mousePosition;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool GetisClickMaintained()
    {
        isClickMaintained = Input.GetMouseButton(0);
        return isClickMaintained;
    }

    public bool GetisClicked()
    {
        isClicked = Input.GetMouseButtonDown(0);
        return isClicked;
    }

    public Vector2 GetMousePos()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        return mousePosition;
    }
}
