using UnityEngine;
using UnityEngine.UI;

public class PlataformaPunto : MonoBehaviour
{
    [SerializeField]
    private Slider sliderPunto;
    private MeshRenderer meshRenderer;
    private float valorPunto;
    [SerializeField]
    private ParticleSystem particle;
    private ParticleSystem.MainModule settings;

    void Awake()
    {
        valorPunto = 0;
        meshRenderer = GetComponent<MeshRenderer>();
        settings = particle.main;
    }

    void Update()
    {
        if (valorPunto > 10)
        {
            meshRenderer.material.color = Color.red;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.red);
            valorPunto = 10;
        }
        if (valorPunto < -10)
        {
            meshRenderer.material.color = Color.blue;
            settings.startColor = new ParticleSystem.MinMaxGradient(Color.blue);
            valorPunto = -10;
        }
        sliderPunto.value = valorPunto;
    }
    public float GetValorPunto()
    {
        return valorPunto;
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            valorPunto += Time.deltaTime;
        }
        else if (collision.gameObject.name == "Player2")
        {
            valorPunto -= Time.deltaTime;
        }
    }
}
