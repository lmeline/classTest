// Créer un objet utilisateur de la classe Utilisateur 
// déclaration d'un entier 
    // int i = 0;

// déclaration d'une variable de type Utilisateur
Utilisateur utilisateur = new Utilisateur("Meline","Loise","coco@lolo.fr","lolololo1");

// afficher les trucs dans la console 
Console.WriteLine(utilisateur.Prenom);
// créer la classe 
class Utilisateur {

// créer un attribut de type string, mettre un ? rend les champs nullables 
public string? Nom { get; set; }
public string? Prenom { get; set; }
public string? Email { get; set; }
//public string? MotDePasse { get; set; }
private string? mdp;
public string? Mdp {
    get{
        return mdp;
    }
    set{
        if(verifMdp (value)){
            mdp = value;
            Console.WriteLine("bravo champion");
        } else {
            Console.WriteLine("Non");
        }

    }
}

// reviens au même, mais plus complexe 
    // private string email;
    // public string Email { get { return email;} set { email = value; } }


    // créer un constructeur (méthode)
    public Utilisateur(string nom, string prenom, string email, string mdp) {
   
        Nom = nom;
        Prenom = prenom;
        Email = email;
        Mdp = mdp;
        
    }

    // créer une méthode 
    private bool verifMdp(string? mdp){

        int nb1 = 0;
        int nb2 = 0;

       foreach (char c in mdp) {
        if (Char.IsDigit(c))
        {
            nb1++;
        }
        else if (Char.IsLetter(c)) {
            nb2++;
        }
        
       }
       if (nb1 >= 1 && nb2 >= 1){
        return true;
       } else {
        return false;
       }
    
    }
}


