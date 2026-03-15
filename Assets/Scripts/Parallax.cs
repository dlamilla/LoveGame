using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float parallaxEffectMultiplier = 0.1f;
    private Material parallaxMaterial;
    private Transform player;
    private float lastPlayerX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        parallaxMaterial = GetComponent<Renderer>().material;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        lastPlayerX = player.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = player.position.x - lastPlayerX;
        parallaxMaterial.mainTextureOffset += new Vector2(deltaX * parallaxEffectMultiplier, 0);
        lastPlayerX = player.position.x;
    }
}
