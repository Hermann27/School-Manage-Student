﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Groupe
    {
        public int Identifiant { get; set; }
        public byte Status { get; set; }
        public string Intitule { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Utilisateur UserUpdate { get; set; }
        public Utilisateur UserCreate { get; set; }

        public Groupe(int id, string Intitule, byte stat, 
                          DateTime dteCreat, DateTime dteUpdat, Utilisateur usrUp, Utilisateur usrCrea)
       {
           
           this.Identifiant = id;
           this.Intitule = Intitule;
           this.Status = stat;
           this.DateCreate = dteCreat;
           this.DateUpdate = dteUpdat;
           this.UserCreate = usrCrea;
           this.UserUpdate = usrUp;

       }

         public Groupe(int id)
       {
           this.Identifiant = id;
       }

         override
         public string ToString()
         {
             return this.Intitule;
         }
    }
}
