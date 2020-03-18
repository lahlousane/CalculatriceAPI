using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CalculatriceAPI.Services.Impl
{
    using DTO;
    public class UtilisateurCalculatriceService : UtilisateurCalculatriceService
    {
        private static List<UtilisateurDTO> utilisateurs = new List<UtilisateurDTO>();
        public IEnumerable<UtilisateurDTO> TrouverTout()
        {
            return utilisateurs.Where(u => u != null);
        }
        public UtilisateurDTO TrouverUnUtilisateur(int id)
        {
            return utilisateurs[id];
        }
        public UtilisateurDTO AjouterUnUtilisateur(UtilisateurDTO user)
        {
            user.Id = utilisateurs.Count();
            utilisateurs.Add(user);
            return user;
        }
        public void SupprimerUtilisateur(int id)
        {
            utilisateurs[id] = null;
        }
        public IEnumerable<UtilisateurDTO> TrouverParNom(string nom)
        {
            return utilisateurs.Where(u => u.Nom == nom);
        }
        public IEnumerable<UtilisateurDTO> TrouverParAge(int age)
        {
            return utilisateurs.Where(u => u.Age == age);
        }
        public IEnumerable<UtilisateurDTO> TrouverParAge(int min, int max)
        {
            return utilisateurs.Where(u => u.Age < max && u.Age > min);
        }
        public IEnumerable<UtilisateurDTO> TrouverParMetier(string metier)
        {
            return utilisateurs.Where(u => u.Metier == metier);
        }
    }
}
    }
}
