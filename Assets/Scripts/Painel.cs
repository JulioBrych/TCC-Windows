using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Painel : MonoBehaviour
{
    private TMP_Text[] textoPaineis;
    public GameObject[] paineis;
    public string[][] textos = new string[2][];
    void Start()
    {
        textoPaineis = this.GetComponentsInChildren<TMP_Text>();
        textos[0] = new string[2];
        textos[1] = new string[2];
        textos[0][0] = "Choana, orif�cio utilizado para respira��o com funcionamento semelhante ao nariz.";
        textos[0][1] = "Os anf�bios Temnospondilos possu�am duas fileiras de dentes nas maxilas.";
        textos[1][0] = "Esse nunca Aparece";
        textos[1][1] = "Coletado em 2003, na Serra da Santa, em Otac�lio Costa (SC), por alunos da disciplina de Ci�ncias Biol�gicas, na disciplina de Paleontologia, coordenados pelo Prof. Juar�s J. Aumond.\nAnf�bio Temnospondilo de rosto curto, similar a uma esp�cie conhecida na R�ssia.O <i>Melosaurus</i>.";

    }

    public void MudaTexto(int contexto, int texto)
    {
        if (contexto > 0 && contexto <= textos.Length)
        {
            if (texto > 0 && texto <= textos[contexto - 1].Length)
            {
                textoPaineis[0].text = textos[contexto - 1][texto - 1];
            }
        }
    }

    public void LimpaPainel()
    {
        textoPaineis[0].text = "";
    }
}
