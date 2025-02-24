using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSecundarioMenager : MonoBehaviour
{

    [SerializeField] private AudioSource somAvancar;
    [SerializeField] private AudioSource somVoltar;

    public void Voltar()
    {
        somVoltar.Play();
        Invoke("CarregarCenaMenuPrincipal", somVoltar.clip.length);
        SceneManager.LoadScene(0);
    }

    public void VoltarInventario()
    {
        somVoltar.Play();
        Invoke("CarregarCenaInventario", somVoltar.clip.length);
    }

    public void AvancaFases()
    {
        somAvancar.Play();
        Invoke("CarregarCenaFases", somAvancar.clip.length);
    }

    private void CarregarCenaMenuPrincipal()
    {
        SceneManager.LoadScene("MenuBlueScene");
    }

    private void CarregarCenaInventario()
    {
        SceneManager.LoadScene("Inventario");
    }

    private void CarregarCenaFases()
    {
        SceneManager.LoadScene("MenuFases");
    }
    
    public void FaseMula(){
        SceneManager.LoadScene("MulaSemCabeca");
    }
}
