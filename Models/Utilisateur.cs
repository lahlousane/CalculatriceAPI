using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CalcuatriceAPI.Models
{
	using DTO;

	public class Utilisateur
	{
		public int Id { get; set; }
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public int Age { get; set; }
		public string Metier { get; set; }

		public Utilisateur() { }
		public Utilisateur(int id, string nom, string prenom, int age, string metier)
		{
			Id = id;
			Nom = nom;
			Prenom = prenom;
			Age = age;
			Metier = metier;
		}
	}
}
