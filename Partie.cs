using System;
using System.Collections.Generic;

public class Partie
{
    public int score;
    public int difficulte;
    public int nombreQuestions;
    public List<Question> listeQuestions;
    public int numeroBonneReponse;
    public int numeroQuestion;

    public Partie(List<Question> listeQuestions)
    {
        this.score = 0;
        this.difficulte = 0;
        this.nombreQuestions = listeQuestions.Count();
        this.listeQuestions = listeQuestions;
        this.numeroQuestion = 0;
    }
}
