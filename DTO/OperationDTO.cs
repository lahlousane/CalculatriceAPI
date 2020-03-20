using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatriceAPI.DTO
{
    using Models;
    public class OperationDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Valeur { get; set; }
        public UtilisateurDTO Auteur { get; set; }

        public OperationDTO() { }

        public OperationDTO(int id, string nom, string valeur, UtilisateurDTO auteur)
        {
            Id = id;
            Nom = nom;
            Valeur = valeur;
            Auteur = auteur;
        }

        public static implicit operator Operation (OperationDTO op)
        {
            return new Operation(op.Id, op.Nom, op.Valeur, op.Auteur);
        }

    }
}
