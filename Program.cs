

// Créer un objet utilisateur de la classe Utilisateur 
// déclaration d'un entier 
    // int i = 0;

// déclaration d'une variable de type Utilisateur
Utilisateur utilisateur = new Utilisateur("Meline","Loise","coco@lolo.fr","lolololo");

Console.WriteLine(utilisateur.Prenom);
// créer la classe 
class Utilisateur {

// créer un attribut de type string, mettre un ? rend les champs nullables 
public string? Nom { get; set; }
public string? Prenom { get; set; }
public string? Email { get; set; }
public string? MotDePasse { get; set; }
private string mdp;
public string Mdp {get{return mdp;}set{mdp= value; }}

// reviens au même, mais plus complexe 
    // private string email;
    // public string Email { get { return email;} set { email = value; } }

// créer un constructeur 
    public Utilisateur(string nom, string prenom, string email, string motDePasse) {
        Nom = nom;
        Prenom = prenom;
        Email = email;
        MotDePasse = motDePasse;
        
    }


}


class verifMdp {

}

